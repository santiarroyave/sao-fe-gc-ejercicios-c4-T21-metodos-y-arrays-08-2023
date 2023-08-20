# C4-T21 Métodos y Arrays
## Enunciados
1. Crea una aplicación de consola que nos calcule el área de un circulo, cuadrado o triangulo. Pediremos que figura queremos calcular su área y según lo introducido pedirá los valores necesarios para calcular el área. Crea un método por cada figura para calcular cada área, este devolverá un número real. Muestra el resultado por pantalla.

    Aquí te mostramos que necesita cada figura:
    - Circulo: (radio^2)*PI
    - Triangulo: (base * altura) / 2
    - Cuadrado: lado * lado
2. Crea una aplicación de consola que nos genere una cantidad de números enteros aleatorios que nosotros le pasaremos por teclado. Crea un método donde pasamos como parámetros entre que números queremos que los genere, podemos pedirlas por teclado antes de generar los números. Este método devolverá un número entero aleatorio. Muestra estos números por pantalla.
3. Crea una aplicación de consola que nos pida un número por teclado y con un método se lo pasamos por parámetro para que nos indique si es o no un número primo, debe devolver true si es primo sino false. Un número primo es aquel solo puede dividirse entre 1 y si mismo. Por ejemplo: 25 no es primo, ya que 25 es divisible entre 5, sin embargo, 17 si es primo.
4. Crea una aplicación de consola que nos calcule el factorial de un número pedido por teclado, lo realizara mediante un método al que le pasamos el número como parámetro.
    Para calcular el factorial, se multiplica los números anteriores hasta llegar a uno. Por ejemplo, si introducimos un 5, realizara esta operación 5*4*3*2*1=120.
5. Crea una aplicación de consola que nos convierta un número en base decimal a binario. Esto lo realizara un método al que le pasaremos el numero como parámetro, devolverá un String con el numero convertido a binario. Para convertir un numero decimal a binario, debemos dividir entre 2 el numero y el resultado de esa división se divide entre 2 de nuevo hasta que no se pueda dividir mas, el resto que obtengamos de cada división formara el numero binario, de abajo a arriba.
6. Crea una aplicación de consola que nos cuente el número de cifras de un número entero positivo (hay que controlarlo) pedido por teclado. Crea un método que realice esta acción, pasando el número por parámetro, devolverá el número de cifras.
7. Crea un aplicación de consola que nos convierta una cantidad de euros introducida por teclado a otra moneda, estas pueden ser a dolares, yenes o libras. El método tendrá como parámetros, la cantidad de euros y la moneda a pasar que sera una cadena, este no devolverá ningún valor, mostrara un mensaje indicando el cambio (void).
    El cambio de divisas son:
    -  0.86 libras es un 1 €
    -  1.28611 $ es un 1 €
    -  129.852 yenes es un 1 €

## Apuntes
### Métodos
```c#
abstract class Motorcycle
{
    // Cualquiera puede llamarlo
    public void StartEngine() { /* Métodos */ }

    // Solo las clases heredadas pueden llamarlo
    protected void AddGas(int gallons) { /* Métodos */ }

    // Las clases heredadas pueden anular/reemplazar (override) la implementación de la clase base
    public virtual int Drive(int miles, int speed) { /* Métodos */ return 1; }

    // Las clases derivadas deben implementarlo
    public abstract double GetStopSpeed();
}
```

### Arrays
- Matriz unidimensional
    ```c#
    int[] array1 = new int[5];
    int[] array2 = {1, 2, 3, 4, 5};
    int[] array3 = new int[] {1, 2, 3, 4, 5};
    ```
- Matrices multidimensionales
    ```c#
    int[,] array2D1 = new int[2,3];
    int[,] array2D2 = { {1, 2, 3}, {1, 2, 3} };
    ```
- Matrices escalonadas (matriz de matrices)
    ```c#
    int[][] jaggedArray = new int[3][];
    
    //Asi se pueden inicializar
    jaggedArray[0] = new int[5];
    jaggedArray[1] = new int[4];
    jaggedArray[2] = new int[2];
    ```
- Matrices de objetos
    ```c#
    // Crea un array para almacenar los CDs
    CD[] cdLibrary = new CD[20];

    // Llenar la biblioteca de CDs con objetos de CD
    for (int i = 0; i < 20; i++)
    {
        cdLibrary[i] = new CD();
    }

    // Añadir valores al primer album
    cdLibrary[0].Album = "See";
    cdLibrary[0].Artist = "The Sharp Band";
    cdLibrary[0].Rating = 10;
    ```
- Colecciones
    ```c#
    List<string> sandwich = new List<string>();
    numeros.Add("bacon");
    numeros.Add("tomato");
    numeros.Insert(1, "lettuce");
    ```
- ArrayList
    ```c#
    ArrayList miAL = new ArrayList();
    miAL.Add("Hola");
    miAL.Add("Mundo");
    miAL.Add("!");

    //Muestra las propiedades y los valores
    Console.WriteLine("Nombre ArrayList: miAL");
    Console.WriteLine("Cantidad: {0}", miAL.Count);
    Console.WriteLine("Capacidad: {0}", miAL.Capacity);

    //Mostrar valores
    Console.WriteLine("Valores:");
    foreach (Object obj in miAL)
        Console.Write(" {0}", obj);
    Console.WriteLine();
    ```
- Diccionario
    ```c#
    // Crea un nuevo diccionario de strings, con claves string
    Dictionary<string,string> openWith = new Dictionary<string,string>();

    // Añadiendo algunos elementos al diccionario
    // No pueden haber claves duplicadas, pero los valores si
    openWith.Add("txt", "notepad.exe");
    openWith.Add("bmp", "paint.exe");
    openWith.Add("dib", "paint.exe");
    openWith.Add("rtf", "wordpad.exe");
    ```

## Notas
- La palabra clave **static** se utiliza para crear elementos de clase sin tener que instanciar la propia clase
    ```c#
    // Lo que permite hacer al poner static
    Ejercicio1.Inicia();

    // Lo que se haría si no se pusiese el static
    Ejercicio1 ejercicio = new Ejercicio1();
    ejercicio.Inicia2()
    ```
    ```c#
    // Clase creada para el ejemplo
    static class Ejercicio1
    {
        public static void Inicia() { /*...*/ }
        public void Inicia2() { /*...*/  }
    }
    ```
- Convenciones de nomenclatura para C#
    1. **PascalCase**: La primera letra de cada palabra en el nombre está en mayúscula. Esta convención se utiliza para nombres de clases, métodos, propiedades y otros elementos públicos. *Ejemplo: MiClase, CalcularSalario, ObtenerNombreCompleto*.

    2. **camelCase**: La primera letra de la primera palabra es minúscula, mientras que las primeras letras de las palabras subsecuentes están en mayúscula. Esta convención se utiliza para nombres de parámetros de métodos, variables locales y otros elementos privados. *Ejemplo: nombreCompleto, calcularTotal*.

    3. **UPPERCASE**: Los nombres en mayúsculas se utilizan generalmente para constantes. Todas las letras están en mayúscula y las palabras se separan con guiones bajos. *Ejemplo: PI, MAXIMO_VALOR*.
- Funciones Math
    ```c#
    // Exponente
    Math.Pow(4, 2);
    // Raíz cuadrada
    Math.Sqrt(4);
    ```