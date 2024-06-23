<!DOCTYPE html>
<html lang="pt-br">
<head>
    <meta charset="UTF-8">
    <meta name="viewport" content="width=device-width, initial-scale=1.0">
</head>
<body>

<h1>Todo List Fullstack</h1>

<p>Uma aplicação fullstack de lista de tarefas (todo list) onde você pode adicionar, editar, excluir e obter todas as tarefas. Também é possível marcar as tarefas como concluídas.</p>

<h2>Índice</h2>
<ul>
    <li><a href="#introdução">Introdução</a></li>
    <li><a href="#instalação">Instalação</a></li>
    <li><a href="#uso">Uso</a></li>
    <li><a href="#funcionalidades">Funcionalidades</a></li>
</ul>

<h2 id="introdução">Introdução</h2>
<p>Esta aplicação permite gerenciar suas tarefas diárias de forma eficiente. Você pode adicionar novas tarefas, editar as existentes, excluir aquelas que não são mais necessárias e marcar as tarefas como concluídas. A interface frontend é construída com Vue.js, enquanto o backend é implementado em ASP.NET.</p>

<h2 id="instalação">Instalação</h2>
<h3>Pré-requisitos</h3>
<p>Antes de iniciar a instalação, certifique-se de ter os seguintes requisitos instalados em sua máquina:</p>
<ul>
    <li>Node.js</li>
    <li>.NET SDK</li>
</ul>

<h3>Passos de instalação</h3>
<ol>
    <li>Clone o repositório:</li>
</ol>
<pre><code>git clone git@github.com:FranGJ7/NoonsoftTest.git
cd NoonsoftTest</code></pre>

<ol start="2">
    <li>Instale as dependências do frontend:</li>
</ol>
<pre><code>cd frontend
npm install</code></pre>

<ol start="3">
    <li>Volte para o diretório raiz e vá para a pasta do backend:</li>
</ol>
<pre><code>cd ../backend</code></pre>

<h2 id="uso">Uso</h2>

<h3>Iniciando o Backend</h3>
<ol>
    <li>Certifique-se de estar no diretório <code>backend</code>:</li>
</ol>
<pre><code>back</code></pre>

<ol start="2">
    <li>Execute o servidor backend:</li>
</ol>
<pre><code>dotnet run --urls "http://localhost:5214"</code></pre>

<h3>Iniciando o Frontend</h3>
<ol>
    <li>Vá para o diretório <code>frontend</code>:</li>
</ol>
<pre><code>cd front</code></pre>

<ol start="2">
    <li>Inicie o servidor de desenvolvimento do frontend:</li>
</ol>
<pre><code>npm run dev</code></pre>

<p>Abra seu navegador e acesse <code>http://localhost:5173/</code> para ver a aplicação em funcionamento localmente ou<code> http://192.168.100.54:5173/</code>  na rede local.</p>

<h2 id="funcionalidades">Funcionalidades</h2>
<ul>
    <li>Adicionar nova tarefa.</li>
    <li>Editar tarefa existente.</li>
    <li>Excluir tarefa.</li>
    <li>Marcar tarefa como concluída.</li>
    <li>Obter todas as tarefas.</li>
</ul>



</body>
</html>
