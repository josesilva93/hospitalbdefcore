using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;
using testefcore.DAO;
using testefcore.models;

namespace testefcore.service
{
    public class Service
    {
        TestContext db = new TestContext();

        public List<Paciente> GetAllPacientes()
        {
            List<Paciente> pacientes = db.Paciente.ToList();
            return pacientes;
        }
        public void Save(Object o)
        {
            db.Add(o);
            db.SaveChanges();
        }
        public Paciente FindPacienteByDNI(string dni)
        {
            Paciente paciente = db.Paciente
                .Where(p => p.dni.Equals(dni)).ToList().First();
                
            return paciente;
        }
        public void UpdatePaciente(Paciente paciente)
        {
            db.Update(paciente);
            db.SaveChanges();
        }
        public void BorrarPaciente(Paciente paciente) 
        {
            db.Remove(paciente);
            db.SaveChanges();
        }
    }

}
