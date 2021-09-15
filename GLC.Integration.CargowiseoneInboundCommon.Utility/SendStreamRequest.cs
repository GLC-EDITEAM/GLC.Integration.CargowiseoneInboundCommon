using CargoWise.eHub.Common;
using CargoWise.eHub.Common.Extensions;
using System;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Text;
using System.Text.RegularExpressions;

namespace GLC.Integration.CargowiseoneInboundCommon.Utility
{
    [Serializable]
    public class SendStreamRequest
    {
        public string constructResp(string id, string start, string end)
        {
            string[] textArray1 = new string[] { "<asciiContent><s:Envelope xmlns:s='http://schemas.xmlsoap.org/soap/envelope/'>< s:Header >< ns0:ActivityId xmlns:ns0 = 'http://CargoWise.com/eHub/2010/06' CorrelationId = 'da1f6c74-9bd5-498a-bade-e0f1c7bddc16' > da1f6c74 - 9bd5 - 498a - bade - e0f1c7bddc16 </ ns0:ActivityId >< ns0:Security xmlns:ns0 = 'http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd' >< u:Timestamp xmlns:u = 'http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-utility-1.0.xsd' xmlns: s = 'http://schemas.xmlsoap.org/soap/envelope/' xmlns: o = 'http://docs.oasis-open.org/wss/2004/01/oasis-200401-wss-wssecurity-secext-1.0.xsd' u: Id = ", id, " >< u:Created >", start, " </ u:Created >< u:Expires >", end, " </ u:Expires ></ u:Timestamp ></ ns0:Security ></ s:Header >< s:Body /> </ s:Envelope ></ asciiContent > " };
            return string.Concat(textArray1);
        }

        public string Extractorder(string filename) =>
            Regex.Split(filename, "_")[1];

        public string Getdatetime()
        {
            DateTime time = new DateTime();
            return DateTime.Now.ToString("u");
        }

        public string GZipDecompress(string strin)
        {
            MemoryStream stream = new MemoryStream(Encoding.ASCII.GetBytes(strin));
            eHubGatewayMessage message = new eHubGatewayMessage
            {
                MessageStream = stream
            };
            StreamReader reader = new StreamReader(message.MessageStream.DecodeAndDecompress());
            return reader.ReadToEnd().ToString();
        }

        public void logdate(string orderno, string statusdesc, string status)
        {
            try
            {
                //PROD Connectionstring

                //string connectionString = @"Data Source=PROD01\CARGOPROD;Initial Catalog=Cargowiseone;Integrated Security=true";

                //Test Connectionstring

                string connectionString = @"Data Source=WEBDEV01;Initial Catalog=Cargowiseone;Integrated Security=true";

                SqlConnection connection = new SqlConnection(connectionString);
                SqlCommand command = new SqlCommand("sp_Log", connection)
                {
                    CommandType = CommandType.StoredProcedure
                };
                command.Parameters.AddWithValue("@orderNo", orderno);
                command.Parameters.AddWithValue("@statusdesc", statusdesc);
                command.Parameters.AddWithValue("@status", status);
                connection.Open();
                command.ExecuteNonQuery();
                connection.Close();
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }

        public void sendmessage(string straddress, string strxmlfile, string strfilename, string strRecipientId, string strSenderId, string strpassword, string orderno)
        {
            try
            {
                CargoWise.eAdapterInboundWebClient.eAdapterInboundWebClient.SendMessage(straddress, strxmlfile, strRecipientId, strSenderId, strpassword);
                this.logdate(orderno, "4.Universal Interchange XML Sent to CWO Inbound Webservice", "Success");
            }
            catch (Exception exception)
            {
                throw exception;
            }
        }
    }
}
