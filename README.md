# Inicializar backend
```
cd \FruitApi\backend
Alterar para a connection string do seu postgres no arquivo AppSettings.json
dotnet ef database update
Inserir dados manualmente no seu banco postgres
dotnet run
```
# Inicializar Frontend
```
cd \FruitApi\frontend
npm install
Com o backend rodando, execute o seguinte comando em outro terminal: npm run serve
```
