/* RESET */
* {
  margin: 0;
  padding: 0;
  box-sizing: border-box;
}

/* BODY */
body {
  font-family: 'Segoe UI', Arial;
  background: linear-gradient(180deg, #0a0a0a, #121212);
  color: white;
}

/* HERO (topo estilo startup) */
.hero {
  text-align: center;
  padding: 80px 20px;
}

.hero h1 {
  font-size: 60px;
}

.hero h1 span {
  background: linear-gradient(90deg, #ff7a00, #ff00c8, #00cfff);
  -webkit-background-clip: text;
  -webkit-text-fill-color: transparent;
}

.hero p {
  color: #aaa;
  margin: 10px 0 30px;
}

/* SEÇÕES */
section {
  max-width: 1000px;
  margin: 40px auto;
  padding: 30px;
}

/* TÍTULOS */
h2 {
  font-size: 28px;
  margin-bottom: 20px;
  color: #6c3cff;
}

/* CARD PADRÃO */
section {
  background: rgba(255,255,255,0.03);
  border-radius: 15px;
  backdrop-filter: blur(10px);
}

/* TEXTO */
p {
  color: #ccc;
  line-height: 1.6;
}

/* IMAGENS PROJETOS */
section img {
  border-radius: 10px;
  margin: 10px;
  transition: 0.3s;
}

section img:hover {
  transform: scale(1.05);
}

/* CONTATO */
.contato {
  text-align: center;
}

form {
  display: flex;
  flex-direction: column;
  gap: 12px;
  margin-top: 20px;
}

input, select, textarea {
  padding: 12px;
  border-radius: 8px;
  border: none;
  background: #1f1f1f;
  color: white;
}

/* BOTÃO PREMIUM */
button {
  padding: 14px;
  border-radius: 8px;
  border: none;
  background: linear-gradient(90deg, #6c3cff, #00cfff);
  color: white;
  font-weight: bold;
  cursor: pointer;
  transition: 0.3s;
}

button:hover {
  transform: translateY(-2px);
  opacity: 0.9;
}

/* FOOTER */
footer {
  text-align: center;
  padding: 30px;
  color: #777;
}
