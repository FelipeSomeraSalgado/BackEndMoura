using Exerício;

Carro Mercedes = new Carro();
Mercedes.DefinirMarca("Mercedes");
Mercedes.ObterMarca();
Mercedes.DefinirModelo("Conversivel");
Mercedes.ObterModelo();
Thread.Sleep(1000);

Mercedes.Acelerar(0);

Thread.Sleep(1000);

Mercedes.Frear(190);

Thread.Sleep(1000);
Mercedes.ObterVelocidade();