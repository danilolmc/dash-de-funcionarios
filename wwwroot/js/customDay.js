$(function () {
  let dataFields = $(".data");

  for (const data of dataFields) {
    data.textContent = data.textContent.split(" ")[0];
  }

  let inputDate = $("#dataInicio");
  let inputDateSaida = $("#dataTermino");


  inputDate.on("input", (e) => {

    let date = new Date(e.target.value);
    let newdate = new Date(date);

    newdate.setDate(newdate.getDate() + 15);
    
    let dd = newdate.getDate() + 1;
    let mm = newdate.getMonth() + 1;
    let yy = newdate.getFullYear();

    let dateFormated = `${yy}-${mm}-${dd}`;

    console.log(inputDateSaida.val(dateFormated));
  });
});
