📱 Sistema de Celulares em .NET

Este projeto foi desenvolvido como desafio prático de Programação Orientada a Objetos (POO) em C# com .NET.
O objetivo é modelar um sistema que simula celulares de diferentes marcas (Nokia e iPhone), aplicando conceitos de abstração, herança e polimorfismo.

🔹 Funcionalidades

Criar celulares a partir de uma classe abstrata (Smartphone).

Permitir que diferentes marcas tenham seu próprio comportamento sobrescrevendo métodos.

Disponibilizar um menu interativo no console para:

📋 Exibir informações do celular (modelo, memória e número).

📞 Fazer ligações.

☎️ Receber ligações.

📲 Instalar aplicativos (com comportamento diferente em cada celular).

🚪 Sair do programa.

🔹 Estrutura do Projeto
TRILHA_NET_POO_DESAFIO
│
├── Models
│   ├── Smartphone.cs   # Classe abstrata (base para celulares)
│   ├── Nokia.cs        # Classe concreta Nokia
│   ├── Iphone.cs       # Classe concreta iPhone
│
├── Program.cs          # Contém o menu interativo

🔹 Principais Classes
🔸 Smartphone (abstrata)

Define propriedades comuns: Numero, Modelo, Memoria.

Métodos implementados:

ExibirInfo() → mostra informações do celular.

Ligar() → simula ligação.

ReceberLigacao() → simula recebimento de ligação.

Método abstrato:

InstalarAplicativo(string nomeApp) → deve ser sobrescrito nas classes filhas.

🔸 Nokia

Herda de Smartphone.

Sobrescreve o método InstalarAplicativo, simulando a instalação pela Loja Nokia.

🔸 iPhone

Herda de Smartphone.

Sobrescreve o método InstalarAplicativo, simulando a instalação pela App Store.

🔹 Exemplo de Uso no Console
### Escolha seu celular ###
1 - Nokia G50 (64GB)
2 - iPhone 15 (256GB)
Opção: 1

Você escolheu: Nokia G50


### MENU DE OPERAÇÕES ###
1 - Exibir informações do celular
2 - Ligar
3 - Receber ligação
4 - Instalar aplicativo
0 - Sair
Opção: 1
Celular: Nokia G50 (64GB) | Número: 119999999

Opção: 2
[Nokia G50 (64GB)] Ligando do número 119999999...

Opção: 4
Digite o nome do aplicativo: Whatsapp
Instalando 'Whatsapp' no Nokia via Loja Nokia...

🔹 Tecnologias Utilizadas

C#

.NET Console Application

Paradigma Orientado a Objetos (POO)

🔹 Conceitos de POO aplicados

✔️ Abstração → Smartphone como modelo base.
✔️ Herança → Nokia e Iphone herdam de Smartphone.
✔️ Polimorfismo → Sobrescrita do método InstalarAplicativo.
✔️ Encapsulamento → Propriedades privadas (Imei) e públicas (Numero, Modelo).

📌 Objetivo final: Demonstrar como estruturar um sistema orientado a objetos com reuso de código e extensibilidade para novos modelos de celular.
