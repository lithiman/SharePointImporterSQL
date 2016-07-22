using Microsoft.SharePoint.Client;
using SP = Microsoft.SharePoint.Client;
using System;
using System.Linq;
using System.Windows.Forms;
using System.Security;
using System.Net;
using System.Data.SqlClient;
using System.Drawing;

namespace SharePointImporter
{
    public partial class Form1 : System.Windows.Forms.Form
    {

        private string CadCn = @"Data Source = AINTBDPER01\AINTBDDESA; Initial Catalog = ERP_aenor_prod_jul2016; Integrated Security = True";
        ClientContext ctx = null;
        Web web = null;
        List list = null;

        private bool _IsConnectedSQL;
        public bool IsConnectedSQL
        {
            get { return _IsConnectedSQL; }
            set
            {
                _IsConnectedSQL = value;

                if (_IsConnectedSQL)
                {
                    lblEstadoSQL.Text = "Conectado";
                    lblEstadoSQL.BackColor = Color.DarkGreen;
                }
                else
                {
                    lblEstadoSQL.Text = "Desconectado";
                    lblEstadoSQL.BackColor = Color.RosyBrown;
                }

            }
        }

        private bool _IsConnected;
        public bool IsConnected
        {
            get { return _IsConnected; }
            set
            {
                _IsConnected = value;

                if (_IsConnected)
                {
                    lblEstado.Text = "Conectado";
                    lblEstado.BackColor = Color.DarkGreen;
                }
                else
                {
                    lblEstado.Text = "Desconectado";
                    lblEstado.BackColor = Color.RosyBrown;
                }
                
            }
        }


        public Form1()
        {
            InitializeComponent();
            IsConnected = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            
            SP.ClientContext oContexto = new SP.ClientContext("https://hartrodtperu.sharepoint.com/Prueba");
            SP.List listaPrueba = oContexto.Web.Lists.GetByTitle("ListaPrueba");
            AutheticateO365("https://hartrodtperu.sharepoint.com/Prueba", "LP@j12345", "lesly.pajuelo@hartrodtperu.onmicrosoft.com");
            
        }

    

        private void AutheticateO365(string url, string password, string userName)
        {
            this.Cursor = Cursors.WaitCursor;
            try
            {
                //SP.ClientContext Context= new SP.ClientContext(url);
                var passWord = new SecureString();
                foreach (char c in password.ToCharArray()) passWord.AppendChar(c);
                //Context.Credentials = new SP.SharePointOnlineCredentials(userName, passWord);
                //var web = Context.Web;
                //Context.Load(web);
                //Context.ExecuteQuery();

                var passWordProxy = new SecureString();
                string passwordProxy = "aenordesarrollo2015";
                foreach (char c in passwordProxy.ToCharArray()) passWordProxy.AppendChar(c);

                
                ctx = new ClientContext(url) { Credentials = new SharePointOnlineCredentials(userName, passWord) };
                ctx.ExecutingWebRequest += (s, e) =>
                {
                    e.WebRequestExecutor.WebRequest.Proxy.Credentials = new NetworkCredential("aparra", passWordProxy, "aenor");
                };

                //web = ctx.Web;
                //ctx.Load(web);
                //ctx.ExecuteQuery();

                list = ctx.Web.Lists.GetByTitle(txtLista.Text);

                
                list.GetItems(SP.CamlQuery.CreateAllItemsQuery());

                ctx.Load(list);

                ctx.ExecuteQuery();

                IsConnected = true;
                //string webTitle =  list.ParentWeb.Title;
                ReadDataList(list, txtLista.Text);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                IsConnected = false;
            }
            finally
            {
                this.Cursor = Cursors.Default;
            }

        }

        private void ReadDataList(SP.List oLista, string NombreLista)
        {
            txtItems.Text = oLista.ItemCount.ToString();
        }

        SqlConnection oCn = null;
        private void button2_Click(object sender, EventArgs e)
        {
            
            try
            {
                //SqlConnection oCn = new SqlConnection(txtSQLServer.Text);
                oCn = new SqlConnection(txtSQLServer.Text);
                oCn.Open();
                IsConnectedSQL = true;
            }
            catch (Exception ex)
            {
                IsConnectedSQL = false;
                MessageBox.Show(ex.Message);
            }
        }

        
        private void button3_Click(object sender, EventArgs e)
        {

            if (oCn != null)
            {
                SqlCommand oCmd = new SqlCommand();
                oCmd.Connection = oCn;
                //oCmd.CommandText = "select top 4  RAZON_SOCIAL  from cliente";
                oCmd.CommandText = txtQuery.Text;

                SqlDataReader reader = oCmd.ExecuteReader();

                if (reader.HasRows)
                {

                    int i = 0;
                    int u = 0;
                    while (reader.Read())
                    {
                        string dato1 = reader.GetString(0); //razon social
                        int dato2 = reader.GetInt32(2); // id_cliente

                        if (reader.IsDBNull(1)) //NO EXISTE SYNC
                        {
                            SP.ListItemCreationInformation itemCreateInfo = new SP.ListItemCreationInformation();
                            
                            SP.ListItem newItem = list.AddItem(itemCreateInfo);

                            newItem["Title"] = dato1;
                            newItem["plms"] = dato2; // idcliente

                            newItem.Update();

                            ctx.ExecuteQuery();

                            InsertarDato(newItem.Id, dato2);
                            i++;
                            lblCountInsert.Text = i.ToString();
                            Application.DoEvents();
                        }
                        else
                        {
                            int datoID = reader.GetInt32(1);
                            try
                            {
                                ListItem oItem = list.GetItemById(datoID);
                                ctx.ExecuteQuery();
                                if (oItem.FieldValues.Count > 0)
                                {
                                    oItem["Title"] = dato1;
                                    oItem["plms"] = dato2;
                                    ctx.ExecuteQuery();
                                }
                            }
                            catch(ServerException ex)
                            {
                                if(ex.ServerErrorCode==-2147024809)
                                {
                                    SP.ListItemCreationInformation itemCreateInfo = new SP.ListItemCreationInformation();

                                    SP.ListItem newItem = list.AddItem(itemCreateInfo);

                                    newItem["Title"] = dato1;
                                    newItem["plms"] = dato2; // idcliente

                                    newItem.Update();

                                    ctx.ExecuteQuery();

                                    InsertarDato(newItem.Id, dato2);
                                    i++;
                                    lblCountInsert.Text = i.ToString();
                                    Application.DoEvents();
                                }
                            }

                            
                            u++;
                            lblCountUpdate.Text = u.ToString();
                            Application.DoEvents();
                        }
                    }
                    
                    MessageBox.Show("Se sincronizo (Insert) " + i.ToString() + " dato(s) correctamente");
                    MessageBox.Show("Se sincronizo (Update) " + u.ToString() + " dato(s) correctamente");
                }
                else
                {
                    MessageBox.Show("No hay datos en la consulta de SQL Server");
                }
                reader.Close();
            }
        }


        private void InsertarDato(int id,int codigoLocal)
        {
            SqlConnection oCn2 = new SqlConnection(CadCn);
            oCn2.Open();
            SqlCommand oCmd = new SqlCommand();
            oCmd.Connection = oCn2;
            oCmd.CommandText = string.Format("insert into pruebas.dbo.SyncClientes (id,ID_CLIENTE,Transferido) VALUES ({0},{1},{2})", id, codigoLocal, 1);
            oCmd.ExecuteNonQuery();
        }
        

    }
}