using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using FE.models;

using Microsoft.Identity.Client;
using FE.Models.LocalModels;


namespace FE.Controllers
{
    public class UsuariosLogInController : Controller
    {
        private readonly Laef4Context _context;

        public UsuariosLogInController(Laef4Context context)
        {
            _context = context;
        }

        //##########################################################################################################################
        // GET: Form Salir
        public IActionResult Salir()
        {
            return View("LogIn");
        }
        public IActionResult Inicio()
        {
            //var x = 1;

            return View();
        }

        // GET: UsuariosLogIn
        public async Task<IActionResult> LogIn(Usuario xUsu)
        {
            try
            {
                if (xUsu.Usr != null || xUsu.Pass != null)
                {
                    var xEm = await _context.Usuarios.FirstOrDefaultAsync(m => m.Usr == xUsu.Usr && m.Pass == xUsu.Pass);
                    if (xEm != null)
                    {
                        //ViewData["xMsg"] = "Usuario encontrado, mandar a otra view...";
                        //ViewData["xValCerYFie"] += "Esperando datos...." + Environment.NewLine;
                        ValidaCertificadoYFiel();

                        return View("Inicio");
                    }
                    else
                    {
                        ViewData["xMsg"] = "No existe usuario...";
                        return View();
                    }
                }
                return View();
            }
            catch (Exception ex)
            {
                ViewData["xMsg"] = ex.Message + " LogIn.";
                return View();
            }
        }

        //##########################################################################################################################

        // GET: UsuariosLogIn
        public IActionResult Index()
        {
            var x = 1;
            var y = 2;  
              return _context.Usuarios != null ? 
                          View(_context.Usuarios.ToList()) :
                          Problem("Entity set 'Laef4Context.Usuarios'  is null.");
        }

        // GET: UsuariosLogIn/Details/5
        public async Task<IActionResult> Details(string id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Usr == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // GET: UsuariosLogIn/Create
        public IActionResult Create()
        {
            return View();
        }

        // POST: UsuariosLogIn/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Usr,Pass,Nombre,Idcliente,Idemisor,Consulta,Agesuc,Appacc")] Usuario usuario)
        {
            if (ModelState.IsValid)
            {
                _context.Add(usuario);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: UsuariosLogIn/Edit/5
        public async Task<IActionResult> Edit(string id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario == null)
            {
                return NotFound();
            }
            return View(usuario);
        }

        // POST: UsuariosLogIn/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(string id, [Bind("Usr,Pass,Nombre,Idcliente,Idemisor,Consulta,Agesuc,Appacc")] Usuario usuario)
        {
            if (id != usuario.Usr)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(usuario);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!UsuarioExists(usuario.Usr))
                    {
                        return NotFound();
                    }
                    else
                    {
                        throw;
                    }
                }
                return RedirectToAction(nameof(Index));
            }
            return View(usuario);
        }

        // GET: UsuariosLogIn/Delete/5
        public async Task<IActionResult> Delete(string id)
        {
            if (id == null || _context.Usuarios == null)
            {
                return NotFound();
            }

            var usuario = await _context.Usuarios
                .FirstOrDefaultAsync(m => m.Usr == id);
            if (usuario == null)
            {
                return NotFound();
            }

            return View(usuario);
        }

        // POST: UsuariosLogIn/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(string id)
        {
            if (_context.Usuarios == null)
            {
                return Problem("Entity set 'Laef4Context.Usuarios'  is null.");
            }
            var usuario = await _context.Usuarios.FindAsync(id);
            if (usuario != null)
            {
                _context.Usuarios.Remove(usuario);
            }
            
            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool UsuarioExists(string id)
        {
          return (_context.Usuarios?.Any(e => e.Usr == id)).GetValueOrDefault();
        }

        //###Others#######################################################################################################################
        public async void ValidaCertificadoYFiel()
        {
            int i;
            i = 0;      
            texto xTexto = new texto();
            xTexto.xTexto1 = "";

            ViewData["xValCerYFie"] += "Esperando datos...1" + Environment.NewLine;

            var task = new Task(async () =>
            {

                //var xEm = (from x in _context.VCertificados
                //           where x.Activo == 1 
                //           select x).ToList();
                //if (xEm.Count() != 0)
                //{
                //    foreach (var x in xEm)
                //    {
                //        i++;
                //        ViewData["xValCerYFie"] = x.Razonsocial + " - " + i;
                //    }
                //}

                var xEm = await _context.ProSerSats.ToListAsync();
                if (xEm.Count() != 0)
                {
                    foreach (var x in xEm)
                    {
                        i++;
                        ViewData["xValCerYFie"] += x.Id + " - " + i + " - " + xEm.Count() + Environment.NewLine;
                    }
                }
            });
            task.Start();
            await task;
            ViewData["xValCerYFie"] += "Esperando datos...2" + Environment.NewLine;

        }

    }
}
