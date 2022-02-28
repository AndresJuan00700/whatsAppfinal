using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Xamarin.Forms;
using Xamarin.Forms.Xaml;

namespace whatsApp
{
    [XamlCompilation(XamlCompilationOptions.Compile)]
    public partial class portada : TabbedPage
    {
        public ObservableCollection<Student> Students { get; set; }
        public portada()
        {
            InitializeComponent();

            Students = new ObservableCollection<Student>
            {
                new Student {FirstName = "Andres", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", fotoestado = "https://cdn.icon-icons.com/icons2/3224/PNG/512/bellboy_hotel_worker_person_man_avatar_icon_196787.png",horaestado="hace 8 minutos", mensaje= "Hiciste lo de programacíon?" },
                new Student {FirstName = "Maria", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",fotoestado="https://cdn.icon-icons.com/icons2/3224/PNG/512/swimming_pool_sun_umbrella_holiday_vacation_icon_196770.png",horaestado="Hoy 10:50 a.m",mensaje = "El negrito tiene clase" },
                new Student {FirstName = "Pepe", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png", fotoestado="https://cdn.icon-icons.com/icons2/3224/PNG/512/hairdryer_dryer_bathroom_hair_hairdressing_icon_196792.png",horaestado="Ayer 6:41 p.m",mensaje= "Hola cómo estas?" },
                new Student {FirstName = "Lina", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",fotoestado="https://cdn.icon-icons.com/icons2/3224/PNG/512/bed_moon_night_bedroom_furniture_icon_196771.png",horaestado="Ayer 2:30 p.m", mensaje= "Qué harás hoy en la noche?" },
                new Student {FirstName = "Andres", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",fotoestado="https://cdn.icon-icons.com/icons2/3224/PNG/512/restaurant_tablecloth_cutlery_spoon_fork_icon_196784.png", mensaje= "Vamos pa los troncos", horaestado="Hoy 10:50 p.m",},
                new Student {FirstName = "Maria", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",fotoestado="https://cdn.icon-icons.com/icons2/3224/PNG/512/luggage_bag_trolley_travel_holiday_icon_196777.png",mensaje = "Aro" ,horaestado="Hoy 5:50 p.m",},
                new Student {FirstName = "Pepe", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",fotoestado="https://cdn.icon-icons.com/icons2/3224/PNG/512/passport_id_card_travel_holiday_vacation_icon_196776.png",mensaje = "LLega" ,horaestado="Hoy 11:00 a.m"},
                new Student {FirstName = "Lina", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",fotoestado="https://cdn.icon-icons.com/icons2/3224/PNG/512/laundry_washing_machine_clothes_clean_wash_icon_196779.png",mensaje = "Mañana si hay clase?" ,horaestado="Hoy 6:00 a.m"},
                new Student {FirstName = "Andres", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",fotoestado="https://cdn.icon-icons.com/icons2/3191/PNG/512/raining_clouds_rain_cloudy_rainy_weather_icon_194235.png", mensaje= "Mañana cumple tu amiga", horaestado="Hoy 10:35 a.m",},
                new Student {FirstName = "Maria", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",fotoestado="https://cdn.icon-icons.com/icons2/3191/PNG/512/sunny_sun_cloud_weather_cloudy_icon_194237.png",mensaje = "Fútbol hoy o que?", horaestado="Hoy 7:00 a.m",},
                new Student {FirstName = "Pepe", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",fotoestado="https://cdn.icon-icons.com/icons2/3191/PNG/512/spring_sun_flowers_summer_sunshine_plant_garden_icon_194259.png", mensaje= "Si" ,horaestado="Hoy 11:30 p.m",},
                new Student {FirstName = "Lina", foto= "https://cdn.icon-icons.com/icons2/1993/PNG/512/camera_digital_photo_photography_picture_record_video_icon_123229.png",fotoestado="https://cdn.icon-icons.com/icons2/3191/PNG/512/cyclone_weather_world_time_icon_194253.png",mensaje = "Un 2" ,horaestado="Hoy 10:50 a.m"}
            };

            this.BindingContext = this;
        }





    }




    }
