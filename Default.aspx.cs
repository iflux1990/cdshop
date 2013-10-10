using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Diagnostics;
using System.Web.UI;
using System.Web.UI.WebControls;

public partial class _Default : Page
{
    private readonly List<Album> albumList = new List<Album>();
    private List<Album> shoppingCart = new List<Album>();
    Label lblShoppingCart = new Label();

    protected void Page_init(object sender, EventArgs e)
    {
        pnlCart.Visible = false;

        addAlbums();
        createInventoryTable();
        
        if (shoppingCart.Count > 0)
        {
            pnlCart.Visible = true;
        }

        //albumtally
        lblAlbumCount.Text = "Total Count: " + albumList.Count;
    }

    protected void createInventoryTable()
    {
        //Inventory list
        try
        {
            var ttt = new Table();
            ttt.ID = "inventory";
            PlaceHolder1.Controls.Add(ttt);
            

            for (int i = 0; i <= albumList.Count - 1; i++)
            {
                Album Album = albumList[i];
                var tr = new TableRow();

                //col 1 (image)
                var td1 = new TableCell();
                var img = new Image();
                img.Width = 100;
                img.Height = 100;
                img.AlternateText = "Image might be missing?";
                img.ImageUrl = albumList[i].image_url;

                td1.Controls.Add(img);

                //col 2 (artist)
                var td2 = new TableCell();
                var lblArtist = new Label();
                lblArtist.Width = 125;
                lblArtist.Text = albumList[i].artist;

                td2.Controls.Add(lblArtist);

                //col 3 (title)
                var td3 = new TableCell();
                var lblTitle = new Label();
                lblTitle.Width = 200;
                lblTitle.Text = albumList[i].title;

                td3.Controls.Add(lblTitle);

                //col 4 (Price)
                var td4 = new TableCell();
                var lblPrice = new Label();
                lblPrice.Width = 50;
                lblPrice.Text = albumList[i].price.ToString();

                td4.Controls.Add(lblPrice);

                //col 5 (addToCart)
                var td5 = new TableCell();
                var btnAddToCart = new Button();
                btnAddToCart.Click += (o, args) =>
                {
                    pnlCart.Visible = true;
                    lblShoppingCart.Text = lblShoppingCart.Text + "- " + Album.title + "<br />";
                    shoppingCart.Add(Album);
                    btnAddToCart.Enabled = false;

                };
                btnAddToCart.CssClass = "miniButton";
                btnAddToCart.Text = "Add to Cart";

                td5.Controls.Add(btnAddToCart);

                //add cols to row
                tr.Cells.Add(td1);
                tr.Cells.Add(td2);
                tr.Cells.Add(td3);
                tr.Cells.Add(td4);
                tr.Cells.Add(td5);

                //adding row to table
                ttt.Rows.Add(tr);

                phShoppingCart.Controls.Add(lblShoppingCart);

            }
        }
        catch (IndexOutOfRangeException)
        {
            var lblError = new Label();
            lblError.Text = "Cought a index out of range exception in the inventory list, something went wrong.";

            phError.Controls.Add(lblError);
        }
    }


    protected void addAlbums()
    {
        var a1 = new Album(1, "Nirvana", "MTV Unplugged in New York", 49.95,
            "http://thedeviousmind.com/wp-content/uploads/2012/02/Mtv-Unplugged-In-New-York.jpg");
        albumList.Add(a1);
        var a2 = new Album(2, "Natasja", "I Danmark er jeg født", 69.95,
            "http://www.playgroundmusic.dk/wp-content/pictures/2013/05/Natasja-cover-LO-585x585.jpg");
        albumList.Add(a2);
        var a3 = new Album(3, "Drake", "Nohting is the same", 69.95,
            "http://www.superbangers.com/wp-content/uploads/2013/09/drake-nothing-the-same-cover-8-22-a.jpg");
        albumList.Add(a3);
        var a4 = new Album(4, "Kings of Leon", "Mechanical Bull", 69.95,
            "http://upload.wikimedia.org/wikipedia/en/5/50/Mechanical-bull.jpg");
        albumList.Add(a4);
        var a5 = new Album(5, "Cher", "Closer to the Truth", 49.95,
            "http://upload.wikimedia.org/wikipedia/en/1/1c/Cher_Closer_to_the_Truth.jpg");
        albumList.Add(a5);
        var a6 = new Album(6, "Elton John", "The Diving Board", 49.95,
            "http://upload.wikimedia.org/wikipedia/en/1/14/Eltonjohn_thedivingboardcover.jpg");
        albumList.Add(a6);
        var a7 = new Album(7, "Jack Johnson", "From Here To Now To You", 69.95,
            "http://upload.wikimedia.org/wikipedia/en/5/5c/Jack_Johnson_From_Here_to_Now_to_You.jpg");
        albumList.Add(a7);
        var a8 = new Album(8, "Luke Bryan", "Crash My Party", 69.95,
            "http://upload.wikimedia.org/wikipedia/en/5/50/CrashMyPartyCD.jpg");
        albumList.Add(a8);
        var a9 = new Album(9, "Dream Theater", "Dream Theater", 49.95,
            "http://fc05.deviantart.net/fs8/i/2005/294/9/a/Dream_Theater_Tribute_by_psychedelic_germ.jpg");
        albumList.Add(a9);
        var a10 = new Album(10, "Katy Perry", "Roar", 69.95,
            "http://cdn.idolator.com/wp-content/uploads/2013/08/14/katy-perry-roar-prism-promo-photo-600x450-600x450.jpg");
        albumList.Add(a10);
    }

    protected void Page_Load(object sender, EventArgs e)
    {
    }

    protected void btnEmptyCart_Click(object sender, EventArgs e)
    {
        lblShoppingCart.Text = "";
        phShoppingCart.Dispose();
        pnlCart.Visible = false;
    }
}