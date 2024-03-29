using System.Data;
using System.Data.Common;
using System.Data.SqlClient;
using System.Windows.Forms;

namespace DisConnectedMode;

public partial class Form1 : Form
{
    SqlConnection sqlConnection;
    SqlDataAdapter dataAdapter;
    DataTable dataTable;
    SqlCommandBuilder sqlCommandBuilder;
    SqlCommand sqlCommand;
    SqlDataReader reader;


    public Form1()
    {
        InitializeComponent();
        string connect = "Data Source=DESKTOP-9FM91S3\\SQLEXPRESS;Initial Catalog=Library;Integrated Security=True;TrustServerCertificate=True;Connect Timeout=30;Encrypt=True;";
        sqlConnection = new SqlConnection(connect);
        findAuthors();
    }



    private void findAuthors()
    {
        dataAdapter = new SqlDataAdapter("SELECT * FROM Authors", sqlConnection);
        dataTable = new DataTable();
        dataAdapter.Fill(dataTable);
        dataGridView.DataSource = dataTable;

    }


    private void btn_select_Click(object sender, EventArgs e)
    {
        try
        {
            sqlConnection.Open();
            sqlCommand=new SqlCommand("SELECT * FROM Authors WHERE FirstName=@name", sqlConnection);
            sqlCommand.Parameters.AddWithValue("@name", SqlDbType.NVarChar).Value = textBox.Text;
            dataAdapter = new SqlDataAdapter(sqlCommand);
            dataTable = new DataTable();
            dataAdapter.Fill(dataTable);
            dataGridView.DataSource = dataTable;

        }
        catch (Exception ex) { 
        }
        finally { sqlConnection.Close(); }
        

    }



    private void btn_exec_click(object sender, EventArgs e)
    {
        sqlCommandBuilder = new SqlCommandBuilder(dataAdapter);
        dataAdapter.Update(dataTable);


    }
}