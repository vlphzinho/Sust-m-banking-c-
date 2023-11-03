using System;
using CSharpShellCore;
using System.Timers;
using System.Runtime.CompilerServices;

class vlp{
   
   static void Main(String[] args){
   
   bool Conta_bancaria = true;
   int saldo_Da_Conta = 1200;
   int limiteDeDeposito = 1000;
   int valorDeDeposito;
   int valor_De_saque;
   int limite_saque = 300;
   char escolha;
   string pago;
     
	 if(Conta_bancaria == true){
	 	
 	 Console.WriteLine("Conta_bancaria <> \n");
 	 Console.WriteLine("qual voce deseja: [a]Sacar [b]depositar [c]pagar [d]sair \n");
	  escolha = char.Parse(Console.ReadLine());
   
   
       switch(escolha){
	     case 'a':
	  	 
		   Console.WriteLine("qual voce deseja: [1]Transferência Eletrônica para Outra Conta [2]Caixas Eletrônicos (ATM) [3]sair \n");
		   escolha = char.Parse(Console.ReadLine());
		   
		   
		     if (escolha ==  '1'){	
		       Console.Write("qual valor que voce deseja sacar?");
			 valor_De_saque = int.Parse(Console.ReadLine()); 
			 
			 if(valor_De_saque <= limite_saque){
			  Console.WriteLine("saque de {0:c} efetuado com sucesso",valor_De_saque);
		
			 }else{
		     Console.WriteLine("Você ultrapassou o limite de saque, saque recusado");
		   }
		   
		   }else if(escolha == '2'){
		     Console.Write("qual valor deseja sacar?");
			 valor_De_saque = int.Parse(Console.ReadLine());
		
			 if(valor_De_saque <= limite_saque){
			    Console.Write("saque de {0:c} efetuado com sucesso",valor_De_saque);
			
			 }else{
			   Console.WriteLine("Você ultrapassou o limite de saque, saque recusado");
			 }
		   }else if(escolha == '3'){
		     return;
		   }
		  break;
          
		  case 'b':
		  
		   Console.WriteLine("voce deseja depositar usando: [1]Pix [2]boleto bancario [3]sair");
		   escolha = char.Parse(Console.ReadLine());
		   
		   if(escolha == '1'){
		    Console.WriteLine("voce deseja depositar qual valor? ");
			valorDeDeposito = int.Parse(Console.ReadLine());
			
			if(valorDeDeposito <= limiteDeDeposito){
			   Console.Write("deposito de {0:c} efetuado com sucesso",valorDeDeposito);
			}else{
			   Console.Write("deposito nao efetuado");
			}
		   }else if(escolha == '2'){
		   Console.Write("voce deseja depositar qual valor ?");
		 valorDeDeposito = int.Parse(Console.ReadLine());
		 
		 Console.WriteLine("\nboleto gerado: numero [xxxxxxxxxxxxxxxxxxx] efetue o pagamento em ate 7 dia uteis \n");
		  Console.WriteLine("\n[a]pago\n[b]nao pago");
		  escolha = char.Parse(Console.ReadLine());
		 
		 if(escolha == 'a'){
		    if(valorDeDeposito <= limiteDeDeposito){
			   Console.WriteLine("deposito de {0:c} efetuado com sucesso",valorDeDeposito);
			}
		 }
		 else if(escolha == 'b'){
			   Console.Write("deposito nao efetuado");
	
		   }
			}else{
				return;
			 // como nao sei retorna para 1 pergunta finalizar...
			}
		  
		  break;
	   
	     case 'c':
		 
		// Console.WriteLine("qual voce deseja: [1]  [2]  [3]sair \n");
		 
		 break;
	     
	   }
   
   }

}
}
