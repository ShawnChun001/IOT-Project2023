using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

using System.Configuration;
using System.Data.SqlClient;

namespace Dashboard
{
    public partial class frmAnalytics : Form
    {
        public frmAnalytics()
        {
            InitializeComponent();
        }

        string strConnectionString = ConfigurationManager.ConnectionStrings["SensorDataDBConnection"].ConnectionString;

        DataComms SensorData;

        public delegate void myprocessDataDelegate(String strData);

        private void saveSensorDataToDB(string strTime, string strValue)
        {
            // Step 1: Create Connection
            SqlConnection myConnect = new SqlConnection(strConnectionString);

            // Step 2: Create Command
            String strCommandText =
                "INSERT SensorData (TimeOccurred, TempValue, LightValue, WaterValue, SoundValue) " +
                " VALUES (@time, @tempvalue, @lightvalue, @watervalue, @soundvalue)";

            SqlCommand updateCmd = new SqlCommand(strCommandText, myConnect);
            updateCmd.Parameters.AddWithValue("@time", strTime);
            updateCmd.Parameters.AddWithValue("@tempvalue", strValue);
            updateCmd.Parameters.AddWithValue("@lightvalue", strValue);
            updateCmd.Parameters.AddWithValue("@watervalue", strValue);
            updateCmd.Parameters.AddWithValue("@soundvalue", strValue);

            // Step 3: Open Connection
            myConnect.Open();

            // Step 4: ExecuteCommand
            int result = updateCmd.ExecuteNonQuery();

            // Step 5: Close Connection
            myConnect.Close();
        } // End saveSensorDataToDB

        // Utility method, you should not need to edit this
        private string extractStringValue(string strData, string ID)
        {
            string result = strData.Substring(strData.IndexOf(ID) + ID.Length);
            return result;
        }

        // Utility method, you should not need to edit this
        private float extractFloatValue(string strData, string ID)
        {
            return (float.Parse(extractStringValue(strData, ID)));
        }

        // Create your own data handler for your project needs
        private void handleLightSensorData(string strData, string strTime, string ID)
        {
            string strlightValue = extractStringValue(strData, ID);

            // Update GUI component in any tabs
            tbLightValue.Text = strlightValue;

            // Update Database
            saveSensorDataToDB(strTime, strlightValue);
        }

        // Create your own data handler for your project needs
        private void handleTempSensorData(string strData, string strTime, string ID)
        {
            string strtempValue = extractStringValue(strData, ID);

            // Update GUI component in any tabs
            tbTempValue.Text = strtempValue;

            // Update Database
            saveSensorDataToDB(strTime, strtempValue);
        }

        // Create your own data handler for your project needs
        private void handleWaterSensorData(string strData, string strTime, string ID)
        {
            string strwaterValue = extractStringValue(strData, ID);

            // Update GUI component in any tabs
            tbWaterValue.Text = strwaterValue;

            // Update Database
            saveSensorDataToDB(strTime, strwaterValue);
        }

        // Create your own data handler for your project needs
        private void handleSoundSensorData(string strData, string strTime, string ID)
        {
            string strsoundValue = extractStringValue(strData, ID);

            // Update GUI component in any tabs
            tbSoundValue.Text = strsoundValue;

            // Update Database
            saveSensorDataToDB(strTime, strsoundValue);
        }

        private void extractSensorData(string strData, string strTime)
        {
            // Any type of data may be send over by hardware
            // so you need to always check what data is received
            // before extracting the information

            // Check whether light value is send
            if (strData.IndexOf("TEMP=") != -1)
                handleTempSensorData(strData, strTime, "TEMP=");
            else if (strData.IndexOf("LIGHT=") != -1)
                handleLightSensorData(strData, strTime, "LIGHT=");
            else if (strData.IndexOf("WATER=") != -1)
                handleWaterSensorData(strData, strTime, "WATER=");
            else if (strData.IndexOf("SOUND=") != -1)
                handleSoundSensorData(strData, strTime, "SOUND=");
        }

        public void handleSensorData(String strData)
        {
            string dt = DateTime.Now.ToString("s"); // Get current time
            extractSensorData(strData, dt); // Get sensor values out

            // Update raw data received to listbox
            string strMessage = dt + ":" + strData;
            lbDataComms.Items.Insert(0, strMessage);
        }
        // This method is automatically called when data is received
        public void processDataReceive(String strData)
        {
            myprocessDataDelegate d = new myprocessDataDelegate(handleSensorData);
            lbDataComms.Invoke(d, new object[] { strData });
        }

        // This method is automatically called when data is received
        public void commsDataReceive(string dataReceived)
        {
            processDataReceive(dataReceived);
        }

        // This method is automatically called when there is error
        public void commsSendError(string errMsg)
        {
            MessageBox.Show(errMsg);
            processDataReceive(errMsg);
        }

        // This method must be called right at the start for data communications
        private void InitComms()
        {
            SensorData = new DataComms();
            SensorData.dataReceiveEvent += new DataComms.DataReceivedDelegate(commsDataReceive);
            SensorData.dataSendErrorEvent += new DataComms.DataSendErrorDelegate(commsSendError);
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void btnClear_Click(object sender, EventArgs e)
        {
            lbDataComms.Items.Clear();
        }

        private void frmAnalytics_Load(object sender, EventArgs e)
        {
            InitComms();
        }
    }
}
