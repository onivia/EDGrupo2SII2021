#include <iostream>
#include <cstdlib>
using namespace std;

struct Factura {
    int codigo;
    char fecha[32];    
};

struct Cliente {
    int nit;
    char razonSocial[32];    
    //AQUI, como relacionarle a cada Cliente sus facturas?
    Factura *facturas;
    int cantidadFacturas;
};

void MostrarDatos(Cliente *clientes, int cantidadClientes) {
    for (int i=0;i<cantidadClientes; i++) {
        cout<<"nit: "<<clientes[i].nit<<endl;
        cout<<"razon social: "<<clientes[i].razonSocial<<endl;
        for (int j=0;j<clientes[i].cantidadFacturas; j++)
        {
            cout<<"\tcodigo: "<<clientes[i].facturas[j].codigo<<endl;            
            cout<<"\tcodigo: "<<clientes[i].facturas[j].fecha<<endl;
        }
    }
}

void LiberarMemoria(Cliente *clientes, int cantidadClientes) {
    for (int i=0;i<cantidadClientes; i++) {
        free(clientes[i].facturas);        
        clientes[i].facturas=NULL;        
    }
    free(clientes);
    clientes=NULL;
}

void CargaDatos(Cliente *clientes, int cantidadClientes) {
    int cantidadFacturas=0;
    Factura *facturas=NULL;
    for (int i=0;i<cantidadClientes; i++) {
        cout<<"Entre nit: "<<endl;
        cin>>clientes[i].nit;
        cin.ignore();
        cout<<"Entre razon social: "<<endl;
        cin.getline(clientes[i].razonSocial,32);
        cout<<"Entre cantidad facturas para este cliente: "<<endl;
        cin>>clientes[i].cantidadFacturas;
        facturas=(Factura *)calloc(clientes[i].cantidadFacturas,sizeof(Factura));
        for (int j=0;j<clientes[i].cantidadFacturas; j++)
        {
            cout<<"\tEntre codigo: "<<endl;
            cin>>facturas[j].codigo;
            cin.ignore();
            cout<<"\tEntre fecha: "<<endl;
            cin.getline(facturas[j].fecha,32);
        }
        clientes[i].facturas=facturas;                
    }
    facturas=NULL;    
}

int main() {
    Cliente *clientes=NULL;
    int cantidadClientes=0;
    cout<<"Entre cantidad de clientes: "<<endl;
    cin>>cantidadClientes;
    clientes=(Cliente *)calloc(cantidadClientes,sizeof(Cliente));
    CargaDatos(clientes, cantidadClientes);
    MostrarDatos(clientes, cantidadClientes);
    LiberarMemoria(clientes, cantidadClientes);
}
