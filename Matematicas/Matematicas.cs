    public class Matematicas
    {
        // Función para verificar si un num es perfecto
        public bool EsPerfecto(int n)
        {
            int suma = 0;
            for (int i = 1; i < n; i++)
            {
                if (n % i == 0)
                    suma += i;
            }
            return suma == n;
        }
    }

