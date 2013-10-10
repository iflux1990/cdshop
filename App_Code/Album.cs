using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Emit;
using System.Web;
using Microsoft.SqlServer.Server;

/// <summary>
/// Summary description for Album
/// </summary>
public class Album
{
    public int ID;
    public string artist;
    public string title;
    public double price;
    public string image_url;


	public Album(int id, string a, string t, double p, string i)
	{
	    ID = id;
	    artist = a;
	    title = t;
	    price = p;
	    image_url = i;
	}

    public override string ToString()
    {
        return string.Format("" + artist + " - " + title + "{0,10:0.00}", price + "\n");
    }
}