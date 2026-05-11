# 🔆 Controle de LEDs (WinForms)

Projeto C# Windows Forms que simula um sistema de controle de LEDs com monitoramento de temperatura por gráfico e controlador PID.

---

## 📌 Funcionalidades

- Controle manual de 8 LEDs
- Modo PID
- Simulação de temperatura baseada nos LEDs ativos
- Gráfico em tempo real (LEDs x Temperatura)
- Histórico de execução em tela
- Exportação de dados para CSV
- Armazenamento em banco SQLite
- Sistema de login de usuário

---

## ⚙️ Tecnologias utilizadas

- C# (.NET Windows Forms)
- SQLite
- Chart (System.Windows.Forms.DataVisualization)

---

## 🚀 Como executar

1. Abra o projeto no Visual Studio
2. Aguarde o carregamento das dependências
3. Compile o projeto
4. Execute (F5)

---

## 🧠 Modos do sistema

- **Manual:** controle direto dos LEDs pelo usuário  
- **PID:** controle automático baseado na temperatura

---

## 📊 Saídas do sistema

- Histórico em tempo real (ListBox)
- Gráfico dinâmico (LEDs x Temperatura)
- Exportação para CSV
- Persistência em banco SQLite (`historico.db`)

---

## 📁 Estrutura do projeto

- `ControleLeds.cs` → lógica principal do sistema  
- `Leds.cs` → controle de estados dos LEDs  
- `PIDController.cs` → controle automático PID  
- `Usuario.cs` → dados do usuário  

---

## 👨‍💻 Autor

Desenvolvido por: Nicollas Bento  

📌 Projeto pessoal para estudo de automação e controle de sistemas.

📅 2026
