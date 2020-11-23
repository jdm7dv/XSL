<%@ Page %>
<%@ Import Namespace="System.Data"%>
<%@ Import Namespace="System.Data.SqlClient"%>
<%@ Import Namespace="System.Xml"%>
<%@ Import Namespace="System.IO"%>
<script language="C#" runat="server">
    public void Page_Load(Object Src, EventArgs E) { 
        DataSet ds = new DataSet();    
        
        //**** Infer the Schema from the customers.xml file
        ds.InferXmlSchema(Server.MapPath("customers.xml"),null);
        
        //**** Add a Table and Row to the Empty DataSet
        ds.Clear(); //Make sure all rows are empty from inferrence above
        DataRow row = ds.Tables["Customers"].NewRow();
        row["CustomerID"] = "DLWID";
        row["CompanyName"] = "Wahlin Consulting";
        row["ContactName"] = "Dan Wahlin";
        row["ContactTitle"] = "Programmer/Author";
        
        //****** Let's see how well the schema validates
        try {
            row["test"] = "Testing Schema";
        }
        catch (Exception exc) {
            //Don't do the insert because column["test"] doesn't really exist
        }
        ds.Tables["Customers"].Rows.Add(row);
        // Code to actually insert the row into a data source would go here.....
        
        BeforeDataGrid.DataSource = ds.Tables["Customers"].DefaultView;
        BeforeDataGrid.DataBind();   
    }
</script>
<html>
    <body bgcolor="#ffffff">
        <form runat="server">
            <h2>
                Data Loaded into a DataSet and Validated by a Schema
            </h2>
            <ASP:DataGrid id="BeforeDataGrid" runat="server" Width="700" BackColor="#E6E6CC" BorderColor="#000000" ShowFooter="false" CellPadding=5 CellSpacing="0" Font-Name="Arial" Font-Size="8pt" HeaderStyle-BackColor="#6C0A00" HeaderStyle-ForeColor="#ffffff" EnableViewState="false" />
        </form>
    </body>
</html>
