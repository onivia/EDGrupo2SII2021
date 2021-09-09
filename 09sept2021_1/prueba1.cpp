#include <iostream>
using namespace std;

float sumar(int num1, int num2) {
    return num1 + num2;
}
float restar(int num1, int num2) {
    return num1 - num2;
}
float multiplicar(int num1, int num2) {
    return num1 * num2;
}
float dividir(int num1, int num2) {
    return float(num1) / float(num2);
}
void ejercicio1() {
    int num1=10, num2=3;
    float r=0.0;
    float (*f1)(int,int)=NULL; //declara el apuntador de tipo funcion

    f1=&restar; //f1 apunta a la funcion restar
    r = (*f1)(num1,num2); //Invocamos la funcion restar por medio del apuntador f1
    //r = sumar(num1,num2);

    cout<<r<<endl;
}

void ejercicio2() {
    int num1=0, num2=0, operacion=0;
    float r=0.0;
    //Declarar un arreglo de apuntadores, apuntadores a funciones
    float (*f1[5])(int,int)={NULL,&sumar,&restar,&multiplicar,&dividir};

    operacion=4; //[1:suma,2-resta,3-multiplicacion,4:division]
    num1=100;
    num2=30;

    r = (*f1[operacion])(num1,num2); //Invocacion dinamica

    cout<<r<<endl;
}

int main() {
    //ejercicio1();    
    ejercicio2();

    return 0;
}
