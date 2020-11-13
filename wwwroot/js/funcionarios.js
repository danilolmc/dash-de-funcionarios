$(function () {
  let btnAlocar = $("#btnSelecionar");
  let vagas = $(".vaga");
  let modalFuncinario = $("#funcModal");
  let idFuncionario = document.getElementById("idf");

  btnAlocar.on("click", (e) => {
    
      alert("Selecionado", e.target.value)
  });
});

function BuscarFuncionario(id) {
  $.ajax({
    url: "https://localhost:5001/Alocacao/BuscarFuncionario",
    type: "get",
    data: { idFuncionario: id },
  })
    .done((response, status) => {
      console.log(response);
    })
    .fail((erro) => {
      console.log(erro);
    });
}
