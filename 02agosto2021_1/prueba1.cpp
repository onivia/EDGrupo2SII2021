#include <iostream>
using namespace std;

void f1(int *p) {
    cout<<*(p+0)<<endl; //expresion x apuntadores
    cout<<p[3]<<endl; //expresion x arreglo
}

int main() {
    int a1[4] = {88,14,60,34};
    
    f1(a1); //se va a pasar la 1era dir de memoria del arreglo 'a1', es decir donde
    //esta el '88'
    
    return 0;
}
