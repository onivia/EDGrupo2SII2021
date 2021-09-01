
#include <iostream>
#include <iomanip>
#include <cstring>
using namespace std;

void f1(int b[]) {
    b[0] += 10;
    b[1] += 10;
}

void ejercicio1() {
    int a1[2] = {50, 80};
    int a1copia[2];

    //copy(begin(a1), end(a1), begin(a1copia)); //otra manera de copiar aun arreglo en otro
    a1copia[0] = a1[0];
    a1copia[1] = a1[1];

    f1(a1copia);

    cout<<"Arreglo original: "<<endl;
    cout<<a1[0]<<endl;
    cout<<a1[1]<<endl;
    cout<<"Arreglo copia: "<<endl;
    cout<<a1copia[0]<<endl;
    cout<<a1copia[1]<<endl;
}

enum TipoOperacion 
{ 
    SUMA = 1 ,
    RESTA = 2,
    MULTIPLICACION = 3,
    DIVISION = 4
};

float operaciones(int num1, int num2, TipoOperacion tipooperacion) {
    switch (tipooperacion)
    {
        case SUMA:
            return num1 + num2;
        case RESTA:
            return num1 - num2;
        case MULTIPLICACION:
            return num1 * num2;
        case DIVISION:
            return float(num1) / float(num2);
        default:
            return 0;           
    }
}

void ejercicio2() {
    /* ALGORITMO INFORMAL:
        1. Declare variables:
            opcion, para definir la operacion
            numero1, 1° numero de la operacion
            numero1, 2° numero de la operacion
            definir una enumeracion para tipificar las operaciones, esta enum se asociara a la 'opcion'
        2. Capture numero1, numero2 y la opcion
        3. Asocie el enum a partir de la 'opcion'
        4. Llame la funcion 'operaciones'
            4.1 'operaciones' segun la enum realiza la operacion y retorna el resultado
        5. Muestre 'resultado'
    */
    //1.
    TipoOperacion tipooperacion;
    int opcion = 0, num1 = 0, num2 = 0;
    float resultado = 0.0;

    //2.
    cout<<"Entre numero1: ";
    cin>>num1;
    cout<<"Entre numero2: ";
    cin>>num2;
    cout<<"Seleccione operacion [1:suma,2-resta,3-multiplicacion,4:division]: ";
    cin>>opcion;

    //3.
    tipooperacion = (TipoOperacion)opcion;

    //4.
    resultado = operaciones(num1,num2,tipooperacion);
    
    //5.
    cout<<"resultado: "<<setprecision(2)<<fixed<<resultado;
}

int main() {
    ejercicio1();
    //ejercicio2();
    
    return 0;
}
