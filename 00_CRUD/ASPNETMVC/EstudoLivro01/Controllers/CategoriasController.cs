using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using System.Web.Mvc;
using EstudoLivro01.Models;

namespace EstudoLivro01.Controllers
{
    public class CategoriasController : Controller
    {
        #region Lista Categoria
        private static IList<Categoria> categorias = new List<Categoria>()
        {
            new Categoria(){
                CategoriaId = 1,
                Nome = "Computadores"            
            },
            new Categoria(){
                CategoriaId = 2,
                Nome = "Monitores"            
            },
            new Categoria(){
                CategoriaId = 3,
                Nome = "Impressoras"            
            }          
        
        };
        #endregion

        // GET: Categorias
        public ActionResult Index()
        {
            return View(categorias);
        }

        // GET: Categorias/Create
        public ActionResult create()
        {
            return View();
        }
        
        //POST CRIA CATEGORIA
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult create(Categoria categoria)
        {
            categorias.Add(categoria);
            categoria.CategoriaId = categorias.Select(m => m.CategoriaId).Max() + 1;
            return RedirectToAction("Index");
        }

        //GET: EDIT
        public ActionResult Edit(long id)
        {
            return View(categorias.Where(m => m.CategoriaId == id).First());
        }
        
        //POST: EDITA CATEGORIA
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Edit( Categoria categoria)
        {
            categorias.Remove(categorias.Where(c => c.CategoriaId == categoria.CategoriaId).First());
            categorias.Add(categoria);
            return RedirectToAction("Index");
        }

        //GET: DETAILS
        public ActionResult Details(long id)
        {
            return View(categorias.Where(m => m.CategoriaId == id).First());
        }

        //GET: DELETE
        public ActionResult Delete(long id)
        {
            return View(categorias.Where(m => m.CategoriaId == id).FirstOrDefault());
        }

        //REMOVE CATEGORIA
        [HttpPost]
        [ValidateAntiForgeryToken]
        public ActionResult Delete(Categoria categoria)
        {
            categorias.Remove(categorias.Where(c => c.CategoriaId == categoria.CategoriaId).FirstOrDefault());
            TempData["Message"] = "CATEGORIA " +  categoria.Nome.ToUpper() + " foi removido";
            return RedirectToAction("Index");
        }
        
        
    
    }
}