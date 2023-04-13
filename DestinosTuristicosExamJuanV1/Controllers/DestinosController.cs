using DestinosTuristicosExamJuanV1.Models;
using Microsoft.AspNetCore.Mvc;

namespace DestinosTuristicosExamJuanV1.Controllers
{
    public class DestinosController : Controller
    {
        public IActionResult Index()
        {
            
            List <Destinos> lst = new List<Destinos> ();  

            using (var db= new Models.DB.DestinosContext())
            {
                lst = (from d in db.DestinosTuristicos
                      select new Destinos
                      {
                          Id = d.Id,
                          Nombre= d.Nombre,
                          Descripcion= d.Descripcion,
                          Foto= d.Foto,
                          Precio = d.Precio,
                         

                        
                      }).ToList (); 
            }
             
            return View(lst);
        }
    }
}
