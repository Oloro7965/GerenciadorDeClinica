using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;
using Microsoft.EntityFrameworkCore;
using GerenciadorDeClinica.Data;
using GerenciadorDeClinica.Models;
using GerenciadorDeClinica.Models.Enums;

namespace GerenciadorDeClinica.Controllers
{
    public class MedicosController : Controller
    {
        private readonly GerenciadorDeClinicaContext _context;

        public MedicosController(GerenciadorDeClinicaContext context)
        {
            _context = context;
        }

        // GET: Medicos
        public async Task<IActionResult> Index()
        {
            return View(await _context.Medico.ToListAsync());
        }

        // GET: Medicos/Details/5
        public async Task<IActionResult> Details(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medico = await _context.Medico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }

            return View(medico);
        }

        // GET: Medicos/Create
        public IActionResult Create()
        {
            ViewBag.Especialidades = new SelectList(Enum.GetValues(typeof(EEspecialidade))
                                              .Cast<EEspecialidade>()
                                              .Select(e => new { Id = (int)e, Nome = e.ToString() }),
                                              "Id", "Nome");
            ViewBag.TipoSanguineo = new SelectList(Enum.GetValues(typeof(ETipoSanguineo))
                                             .Cast<ETipoSanguineo>()
                                             .Select(e => new { Id = (int)e, Nome = e.ToString() }),
                                             "Id", "Nome");
            return View();
        }

        // POST: Medicos/Create
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Create([Bind("Nome,Sobrenome,DataNascimento,telefone,email,Cpf,endereco,tipoSanguineo,CRM,especialidade")] Medico medico)
        {
            if (!Enum.IsDefined(typeof(EEspecialidade), medico.especialidade))
            {
                ModelState.AddModelError("Especialidade", "Especialidade inválida.");
            }

            // Verifica se o tipo sanguíneo é válido
            if (!Enum.IsDefined(typeof(ETipoSanguineo), medico.tipoSanguineo))
            {
                ModelState.AddModelError("TipoSanguineo", "Tipo sanguíneo inválido.");
            }
            if (ModelState.IsValid)
            {
                _context.Add(medico);
                await _context.SaveChangesAsync();
                return RedirectToAction(nameof(Index));
            }
            ViewBag.Especialidades = new SelectList(Enum.GetValues(typeof(EEspecialidade))
                                             .Cast<EEspecialidade>()
                                             .Select(e => new { Id = (int)e, Nome = e.ToString() }),
                                             "Id", "Nome");
            ViewBag.TipoSanguineo = new SelectList(Enum.GetValues(typeof(ETipoSanguineo))
                                            .Cast<ETipoSanguineo>()
                                            .Select(e => new { Id = (int)e, Nome = e.ToString() }),
                                            "Id", "Nome");
            return View(medico);
        }

        // GET: Medicos/Edit/5
        public async Task<IActionResult> Edit(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medico = await _context.Medico.FindAsync(id);
            if (medico == null)
            {
                return NotFound();
            }
            return View(medico);
        }

        // POST: Medicos/Edit/5
        // To protect from overposting attacks, enable the specific properties you want to bind to.
        // For more details, see http://go.microsoft.com/fwlink/?LinkId=317598.
        [HttpPost]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> Edit(Guid id, [Bind("Nome,Sobrenome,DataNascimento,telefone,email,Cpf,endereco,tipoSanguineo,CRM,especialidade,Id")] Medico medico)
        {
            if (id != medico.Id)
            {
                return NotFound();
            }

            if (ModelState.IsValid)
            {
                try
                {
                    _context.Update(medico);
                    await _context.SaveChangesAsync();
                }
                catch (DbUpdateConcurrencyException)
                {
                    if (!MedicoExists(medico.Id))
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
            return View(medico);
        }

        // GET: Medicos/Delete/5
        public async Task<IActionResult> Delete(Guid? id)
        {
            if (id == null)
            {
                return NotFound();
            }

            var medico = await _context.Medico
                .FirstOrDefaultAsync(m => m.Id == id);
            if (medico == null)
            {
                return NotFound();
            }

            return View(medico);
        }

        // POST: Medicos/Delete/5
        [HttpPost, ActionName("Delete")]
        [ValidateAntiForgeryToken]
        public async Task<IActionResult> DeleteConfirmed(Guid id)
        {
            var medico = await _context.Medico.FindAsync(id);
            if (medico != null)
            {
                _context.Medico.Remove(medico);
            }

            await _context.SaveChangesAsync();
            return RedirectToAction(nameof(Index));
        }

        private bool MedicoExists(Guid id)
        {
            return _context.Medico.Any(e => e.Id == id);
        }
    }
}
