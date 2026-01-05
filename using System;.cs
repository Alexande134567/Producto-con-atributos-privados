using System;

namespace Ejemplo
{
    class Producto
    {
        // Atributos privados
        private string codigo;
        private string descripcion;
        private double precio;

        // Constructor vacío (opcional)
        public Producto()
        {
        }

        // Métodos getter y setter

        public string GetCodigo()
        {
            return codigo;
        }

        public void SetCodigo(string codigo)
        {
            this.codigo = codigo;
        }

        public string GetDescripcion()
        {
            return descripcion;
        }

        public void SetDescripcion(string descripcion)
        {
            this.descripcion = descripcion;
        }

        public double GetPrecio()
        {
            return precio;
        }

        public void SetPrecio(double precio)
        {
            this.precio = precio;
        }
    }
}


