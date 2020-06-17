using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;
using NaN.Data;

namespace NaN.Models
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class Specialités : ContentPage
    {
        public Specialités()
        {
            InitializeComponent();

            Special csharp = new Special
            {
                Title = "C_sharp et Xamarin",
                ImageUrl = "csharp",
                Theme = "Mobile web et Desktop",
                Description = "Xamarin est une plate-forme open source pour créer des applications modernes et performantes pour iOS, Android et Windows avec .NET. Xamarin est une couche d'abstraction qui gère la communication du code partagé avec le code de plate-forme sous-jacent. Xamarin s'exécute dans un environnement géré qui offre des commodités telles que l'allocation de mémoire et le garbage collection Xamarin permet aux développeurs de partager en moyenne 90 % de leur application sur toutes les plateformes.Ce modèle permet aux développeurs d'écrire toute leur logique métier dans un seul langage (ou de réutiliser le code dapplication existant) mais dobtenir des performances, une apparence et une convivialité natives sur chaque plateforme.",
                Lecon = "C_sharp lessons is not add for the instance please see every time"
            };
            Special Databases = new Special
            {
                Title = "Database",
                ImageUrl = "Database",
                Theme = "Bases de données",
                Description = "Une base de données (en anglais database), permet de stocker et de retrouver l'intégralité de données brutes ou d'informations en rapport avec un thème ou une activité ; celles-ci peuvent être de natures différentes et plus ou moins reliées entre elles.",
                Lecon = "Database lessons is not add for the instance please see every time"
            };
            Special Flutter = new Special
            {
                Title = "Flutter",
                ImageUrl = "Flutter.png",
                Theme = "Mobile",
                Description = "Flutter, le framework de Google permettant de concevoir des applications multiplateforme pour Android et iOS, est désormais disponible en Release Preview 2. La première version stable ne devrait plus tarder à pointer le bout de son nez.",
                Lecon = "Flutter lessons is not add for the instance please see every time"
            };
            Special front = new Special
            {
                Title = "Front-End",
                ImageUrl = "Front",
                Theme = "Mobile et Web",
                Description = "Le développement web frontal (aussi appelé front-end en anglais) correspond aux productions HTML, CSS et JavaScript d’une page internet ou d’une application qu’un utilisateur peut voir et avec lesquelles il peut interagir directement.Le principal défi du développement web frontal est de toujours s'adapter aux dernières évolutions ; les outils et les techniques de développement étant en évolution constante.La conception des sites internet doit également être capable d’offrir une bonne ergonomie de lecture en facilitant la navigation et l’obtention d’information.Cet objectif est d’autant plus compliqué que les lecteurs utilisent maintenant différentes plateformes de format et de taille variés.Le développeur doit donc s’assurer que le site internet apparait correctement sur l’ensemble des navigateurs Web et des plateformes / appareils disponibles.",
                Lecon = "Front-end lessons is not add for the instance please see every time"
            };
            Special python = new Special
            {
                Title = "Python",
                ImageUrl = "Python",
                Theme = "Web, mobile et jeux",
                Description = "Le langage Python est placé sous une licence libre proche de la licence BSD6 et fonctionne sur la plupart des plates-formes informatiques, des smartphones aux ordinateurs centraux7, de Windows à Unix avec notamment GNU/Linux en passant par macOS, ou encore Android, iOS, et peut aussi être traduit en Java ou .NET. Il est conçu pour optimiser la productivité des programmeurs en offrant des outils de haut niveau et une syntaxe simple à utiliser.",
                Lecon = "Python lessons is not add for the instance please see every time"
            };
            Special photo = new Special
            {
                Title = "PhotoShop",
                ImageUrl = "Photo",
                Theme = "Multimédia",
                Description = "Photoshop est un logiciel de retouche, de traitement et de dessin assisté par ordinateur, lancé en 1990 sur MacOS puis en 1992 sur Windows. Édité par Adobe, il est principalement utilisé pour le traitement des photographies numériques, mais sert également à la création ex nihilo d’images.",
                Lecon = "PhotoShop lessons is not add for the instance please see every time"
            };

            List<Special> listner = new List<Special>() {csharp,photo,python,Flutter, front,Databases };
            specialites.ItemsSource = listner;

            specialites.ItemSelected += Specialites_ItemSelected;
        }

        private void Specialites_ItemSelected(object sender, SelectedItemChangedEventArgs e)
        {
            var viewer = (Special)e.SelectedItem;

            Navigation.PushAsync(new ViewSpe(viewer));
        }
    }
}