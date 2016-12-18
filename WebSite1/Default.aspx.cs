using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : System.Web.UI.Page
{
    ServiceReference2.BooksOperationsClient boc = new ServiceReference2.BooksOperationsClient();

    protected void Page_Load(object sender, EventArgs e)
    {
        List<ServiceReference2.BookData> books = new List<ServiceReference2.BookData>();
        books = boc.GetBooksTitle().ToList();
        ddlBooks.Items.Add(new ListItem("Please select Book", "0"));
        foreach (ServiceReference2.BookData book in books)
        {
            ddlBooks.Items.Add(new ListItem(book.title, book.id));
        }
    }

    protected void btnGo_Click(object sender, EventArgs e)
    {
        ServiceReference2.BookData bookInfo = new ServiceReference2.BookData();
        bookInfo = boc.GetBookData(ddlBooks.SelectedValue);
        if (bookInfo != null) {
            tbAuthor.Text = bookInfo.author;
            tbTitle.Text = bookInfo.title;
            tbGenre.Text = bookInfo.genre;
            tbPrice.Text = bookInfo.price.ToString();
            tbPDate.Text = bookInfo.publishDate;
            tbDescr.Text = bookInfo.description;

        } else {
            tbAuthor.Text = "Error!";
        }
    }
}