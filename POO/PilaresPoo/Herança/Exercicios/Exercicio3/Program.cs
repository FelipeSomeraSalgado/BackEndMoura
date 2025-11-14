using Heranca;

Carro carro1 = new Carro();
Moto moto1 = new Moto();

carro1.Marca = "Toyota";
carro1.Modelo = "Corolla";
carro1.NumeroPortas = 4;

moto1.Marca = "Honda";
moto1.Modelo = "CG 160";
moto1.TipoCapacete = "Fechado";

carro1.MostrarInfo();
Console.WriteLine();

moto1.MostrarInfo();
