using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Threading.Tasks;
using static System.Net.Mime.MediaTypeNames;

namespace PractisingImageUpload.Models
{
    public class ProductDataAccessLayer
    {

        public string ProductImageLocation { get; set; }
        public byte[] ProductImageData { get; set; }
        public string ProductName { get; set; }
        public string ProductDescription { get; set; }
        public int ProductPrice { get; set; }
        public byte[] ImageInByteForm { get; set; }
        public string ImageInStringForm { get; set; }
        public List<String> ProductImages { get; set; }
        public List<string> ProductNames { get; set; }
        public List<string> ProductDescriptions { get; set; }
        public List<string> ProductPrices { get; set; }

        public string ConToTheDatabase = "Server=tcp:ngetumain.database.windows.net,1433;Initial Catalog=ProductStorage;Persist Security Info=False;User ID=MKNgetu;Password=WtiJXaqAZH8y5re;MultipleActiveResultSets=False;Encrypt=True;TrustServerCertificate=False;Connection Timeout=30;";

       public void CreateANewProduct()
        {
            //Adding Product To Database
            using (SqlConnection AO = new SqlConnection(ConToTheDatabase))
            {

                SqlCommand InsertProductImage = new SqlCommand("SP_CreateAProduct", AO);
                InsertProductImage.CommandType = CommandType.StoredProcedure;




                SqlParameter Picture = new SqlParameter();
                Picture.ParameterName = "@Picture";
                Picture.SqlDbType = SqlDbType.Image;
                Picture.Value = ProductImageData;

                SqlParameter TheProductsName1 = new SqlParameter();
                TheProductsName1.ParameterName = "@ItemName";
                TheProductsName1.SqlDbType = SqlDbType.VarChar;
                TheProductsName1.Value = ProductName;

                SqlParameter TheProductsDescription1 = new SqlParameter();
                TheProductsDescription1.ParameterName = "@ItemDescription";
                TheProductsDescription1.SqlDbType = SqlDbType.VarChar;
                TheProductsDescription1.Value = ProductDescription;

                SqlParameter TheProductsPrice1 = new SqlParameter();
                TheProductsPrice1.ParameterName = "@ItemPrice";
                TheProductsPrice1.SqlDbType = SqlDbType.Int;
                TheProductsPrice1.Value = ProductPrice;

                InsertProductImage.Parameters.Add(Picture);
                InsertProductImage.Parameters.Add(TheProductsName1);
                InsertProductImage.Parameters.Add(TheProductsDescription1);
                InsertProductImage.Parameters.Add(TheProductsPrice1);
                AO.Open();

                InsertProductImage.ExecuteNonQuery();

                AO.Close();




            }






        }
        public void UpdateAProduct()
        {
            //Updating a product within the database
            using (SqlConnection AJ = new SqlConnection(ConToTheDatabase))
            {

                SqlCommand UpdateProducts = new SqlCommand("SP_UpdateAProduct", AJ);
                UpdateProducts.CommandType = CommandType.StoredProcedure;


                SqlParameter UpdatedProductImage = new SqlParameter();
                UpdatedProductImage.ParameterName = "@Picture";
                UpdatedProductImage.SqlDbType = SqlDbType.Image;
                UpdatedProductImage.Value = ProductImageData;

                SqlParameter UpdatedProductName = new SqlParameter();
                UpdatedProductName.ParameterName = "@ItemName";
                UpdatedProductName.SqlDbType = SqlDbType.VarChar;
                UpdatedProductName.Value = ProductName;

                SqlParameter UpdatedDescription = new SqlParameter();
                UpdatedDescription.ParameterName = "@ItemDescription";
                UpdatedDescription.SqlDbType = SqlDbType.VarChar;
                UpdatedDescription.Value = ProductDescription;

                SqlParameter UpdatedProductPrice = new SqlParameter();
                UpdatedProductPrice.ParameterName = "@ItemPrice";
                UpdatedProductPrice.SqlDbType = SqlDbType.Int;
                UpdatedProductPrice.Value = ProductPrice;

                UpdateProducts.Parameters.Add(UpdatedProductImage);
                UpdateProducts.Parameters.Add(UpdatedProductName);
                UpdateProducts.Parameters.Add(UpdatedDescription);
                UpdateProducts.Parameters.Add(UpdatedProductPrice);

                AJ.Open();

                UpdateProducts.ExecuteNonQuery();

                AJ.Close();




            }



        }

        public void RemoveAProduct()
        {
            //Removing A Product To Database
            using (SqlConnection AP = new SqlConnection(ConToTheDatabase))
            {

                SqlCommand RemoveAProduct = new SqlCommand("SP_RemoveAProduct", AP);
                RemoveAProduct.CommandType = CommandType.StoredProcedure;

                SqlParameter Item = new SqlParameter();
                Item.ParameterName = "@ItemName";
                Item.SqlDbType = SqlDbType.VarChar;
                Item.Value = ProductName;



                RemoveAProduct.Parameters.Add(Item);

                AP.Open();

                RemoveAProduct.ExecuteNonQuery();

                AP.Close();




            }



        }
        //Displaying All The Products In The Store
        public void ViewAllStoreProducts()
        {
            ProductImages = new List<String>();
            ProductNames =  new List<string>();
            ProductDescriptions = new List<string>();
            ProductPrices = new List<string>();

            using (SqlConnection ALL = new SqlConnection(ConToTheDatabase))
            {
                SqlCommand ViewAllProducts = new SqlCommand("SELECT Picture,ItemName,ItemDescription,ItemPrice FROM Products", ALL);
                ViewAllProducts.CommandType = CommandType.Text;

                ALL.Open();


                SqlDataReader GG = ViewAllProducts.ExecuteReader();

                while (GG.Read())
                {
                    
                    ImageInByteForm = (byte[])GG["Picture"];
                    ImageInStringForm = Convert.ToBase64String(ImageInByteForm);//(Ingrom, s.a).

                    ProductName = Convert.ToString(GG["ItemName"].ToString());
                    ProductDescription = Convert.ToString(GG["ItemDescription"].ToString());
                    ProductPrice = int.Parse(GG["ItemPrice"].ToString());

                    ProductImages.Add(ImageInStringForm);
                    ProductNames.Add(ProductName);
                    ProductDescriptions.Add(ProductDescription);
                    ProductPrices.Add("R"+ProductPrice.ToString());


                    

                }


               

                ALL.Close();

            }



            


        }


    }
}
