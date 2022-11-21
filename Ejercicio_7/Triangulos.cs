class Triangulos{
    public int num1;
    public int num2;
    public int num3;
    public int suma;
    public string resp;
    public void OPtipoTriangulo(){
        do{
        Console.WriteLine("Ingrese el primer número");
        num1=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el segundo número");
        num2=Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Ingrese el tercer número");
        num3=Convert.ToInt32(Console.ReadLine());
        
        if (num1==num2 && num1==num3){
            Console.WriteLine("El triangulo es equilatero");
        }else if(num1==num2 | num1==num3 | num2==num3){
            Console.WriteLine("El triangulo es isóseles");
        }else{
            Console.WriteLine("El triángulo es escaleno");
        }
        Console.WriteLine("¿Quieres continuar?");
        resp=Console.ReadLine();
        }while(resp=="S" | resp=="s");
        Console.WriteLine("El programa a finalizado");
    }

}