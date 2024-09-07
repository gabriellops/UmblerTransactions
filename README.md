# Funcionalidades

- Criar novas transações utilizando a API da Cielo.
- Capturar transações existentes com o ID de pagamento
- Cancelar transações previamente criadas com o ID do pagamento.

# Como usar

## Pré-requisitos 
.NET SDK 8.0

``` bash
# Clone o repositório:
$ git clone https://github.com/gabriellops/UmblerTransactions.git

# Acesse a pasta da solução:
$ cd UmblerTransactions

# Abra o arquivo de solução no Visual Studio.
# Pressione o botão de executar ou a tecla F5 e aguarde alguns segundos para que a aplicação seja iniciada.
```

# Endpoints

- [POST]: /apicielo/1/sales/ - Cria transação.
- [PUT]: /apicielo/1/sales/{paymentId}/capture - Captura transação.
- [PUT]: /apicielo/1/sales/{paymentId}/void - Cancela transação.
