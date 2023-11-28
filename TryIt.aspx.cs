using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;
using MyLibrary;

namespace CSE445_Project5
{
    public partial class TryIt : System.Web.UI.Page
    {
        protected void Page_Load(object sender, EventArgs e)
        {
           
        }

        protected void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        protected void EncryptBtn_Click(object sender, EventArgs e)
        {
            string originalPassword = TextBox1.Text;
            string encryptedPassword = EncryptionHelper.Encrypt(originalPassword);
            lblEncryptedPassword.Text = $"Encrypted Password: {encryptedPassword}";

        }

        protected void DecryptBtn_Click(object sender, EventArgs e)
        {
            string originalPassword = TextBox1.Text;
            string decryptedPassword = EncryptionHelper.Decrypt(originalPassword);
            lblDecryptedPassword.Text = $"Decrypted Password: {decryptedPassword}";

        }

        protected void Button1_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client Service = new ServiceReference1.Service1Client();

            string input = TextBox2.Text;

            string wordFilter = Service.WordFilter(input);

            resultLabel.Text = wordFilter.ToString();
        }

      

        protected void ConvertButton_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            string input = TextBox3.Text;

            string num2words = service.Number2Words(input);

            resultLabel1.Text = num2words.ToString();
        }

        protected void TextBox2_TextChanged(object sender, EventArgs e)
        {

        }

        protected void Button2_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            try
            {
                // Call the GetRandomRecipe method on the WCF service
                string result = service.GetRandomRecipe();

                // Display the result in a label
                Label1.Text = result;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the service call
                Label1.Text = "Error: " + ex.Message;
            }
            finally
            {
                // Close the service client to release resources
                service.Close();
            }
        }

        protected void Button3_Click(object sender, EventArgs e)
        {
            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            string input = TextBox4.Text;
            string result = service.GetWineDescription(input);
            Label2.Text = result;

        }

        protected void Button4_Click(object sender, EventArgs e)
        {

            string query = TextBox5.Text; // Get the user's query from an input field

            ServiceReference1.Service1Client service = new ServiceReference1.Service1Client();

            try
            {
                // Call the AnalyzeRecipeQuery method on the WCF service
                string analysisResult = service.AnalyzeRecipe(query);

                // Display the analysis result in a label or process it further
                Label3.Text = analysisResult;
            }
            catch (Exception ex)
            {
                // Handle any exceptions that may occur during the service call
                Label3.Text = "Error: " + ex.Message;
            }
            finally
            {
                // Close the service client to release resources
                service.Close();
            }
        }

        protected void TextBox3_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox4_TextChanged(object sender, EventArgs e)
        {

        }

        protected void TextBox5_TextChanged(object sender, EventArgs e)
        {

        }
    }
}