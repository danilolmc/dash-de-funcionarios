let btnPopular = $("#btnPopular");

btnPopular.on("click", () => {
  PopularBanco();
});

function PopularBanco() {
  $.ajax({
    url: "https://localhost:5001/Popular/PopularBanco",
    type: "post",
  })
    .done((response) => {
      if (response == "1") {
        alert("Banco populado com sucesso");
      } else {
        alert("O banco já foi populado");
      }
    })
    .fail((erro) => {
      console.log(erro);
    });
}
