using ExamenTeorico.Protuctos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Xamarin.Forms;

namespace ExamenTeorico
{
    public partial class MainPage : ContentPage
    {
        public IList<Datos> Productos { get; private set; }
        public MainPage()
        {
            InitializeComponent();
            Productos = new List<Datos>();

            Productos.Add(new Datos
            {
                Nombre = "Coca Cola",
                ID = "123456789",
                Precio = "12 BS",
                Url = "https://cdn.computerhoy.com/sites/navi.axelspringer.es/public/media/image/2020/02/coca-cola-portada-1877741.jpg",
                CodigoBarras = "3938200039",
                Cantidad = "15"
            });
            Productos.Add(new Datos
            {
                Nombre = "Fanta",
                ID = "213456789",
                Precio = "12 BS",
                Url = "https://tuchacrita.pe/563-big_default_2x/gaseosa-fanta.jpg",
                CodigoBarras = "4068942718",
                Cantidad = "15"
            });
            Productos.Add(new Datos
            {
                Nombre = "Sprite",
                ID = "312456789",
                Precio = "12 BS",
                Url = "https://www.cocacola.es/content/dam/GO/sprite/spain/home/SP_1,5L_BA_800x654.jpg",
                CodigoBarras = "1004957602",
                Cantidad = "15"
            });
            Productos.Add(new Datos
            {
                Nombre = "Pepsi",
                ID = "412356789",
                Precio = "12 BS",
                Url = "https://image.shutterstock.com/image-photo/konotop-ukraine-march-13-2016-260nw-389825848.jpg",
                CodigoBarras = "5097604967",
                Cantidad = "15"
            });
            Productos.Add(new Datos
            {
                Nombre = "Salvieti",
                ID = "512346789",
                Precio = "9.50 BS",
                Url = "https://www.ketal.com.bo/image/cache/catalog/product/80154746-550x550.jpg",
                CodigoBarras = "6038921095",
                Cantidad = "15"
            }); Productos.Add(new Datos
            {
                Nombre = "7up",
                ID = "612345789",
                Precio = "9.50 BS",
                Url = "https://www.7up.com//images/catalog/products/2015/12/17/7up_diet.png",
                CodigoBarras = "1930569908",
                Cantidad = "15"
            }); Productos.Add(new Datos
            {
                Nombre = "Leche Pil",
                ID = "712345689",
                Precio = "6 BS",
                Url = "https://pilandina.com.bo/wp-content/uploads/2019/06/lechedeslactosada-600x600.png",
                CodigoBarras = "1358904569",
                Cantidad = "5"
            });
            BindingContext = this;
        }
        private void ListView_ItemSlected(object sender, SelectedItemChangedEventArgs e) 
        {
            Datos selectdItem = e.SelectedItem as Datos;
        }
        private void ListView_ItemTapped(object sender, ItemTappedEventArgs e) 
        {
            Datos tappedSelected = e.Item as Datos;
        }
    }
}
