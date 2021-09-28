#include <iostream>
#include <cstdlib>
using namespace std;

struct Punto {
    int x;
    int y;
};

int main() {
    Punto *puntos = NULL;

    //puntos = (Punto *)malloc(2*sizeof(Punto));    
    puntos = new Punto[1]; //malloc
    puntos[0].x = 100;
    puntos[0].y = 200;

    cout<<puntos[0].x<<endl;
    cout<<puntos[0].y<<endl;

    //free(puntos);
    //puntos = NULL;
    delete[] puntos;

    return 0;
}
