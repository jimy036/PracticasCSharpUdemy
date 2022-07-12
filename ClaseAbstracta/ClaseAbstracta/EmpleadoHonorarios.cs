using System;


namespace ClaseAbstracta
{
    class EmpleadoHonorarios : Empleado
    {
        public decimal SueldoBase { get; set; }
        public override decimal Salario
        {
            get
            {
                return SueldoBase * 0.84m;
            }
        }

        public EmpleadoHonorarios(string name, string puesto, decimal sueldoBase) : base(name, puesto)
        {
            SueldoBase = sueldoBase;
        }

        public override void Trabajar()
        {
            Console.WriteLine("Trabajando por honorarios");
        }
    }
}
