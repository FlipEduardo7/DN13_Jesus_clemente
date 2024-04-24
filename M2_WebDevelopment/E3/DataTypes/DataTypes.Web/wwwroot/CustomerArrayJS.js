class Customer {
    constructor(name, fecha) {
        this.name = name;
        this.fecha = fecha;
    }
}

let customers = [];
let fechaActual = new Date();

let customer1 = new Customer("Juan", fechaActual.toLocaleDateString());
let customer2 = new Customer("Ernesto", fechaActual.toLocaleDateString());
let customer3 = new Customer("Teresa", fechaActual.toLocaleDateString());
let customer4 = new Customer("Tony", fechaActual.toLocaleDateString());
let customer5 = new Customer("Carlo", fechaActual.toLocaleDateString());
let customer6 = new Customer("Gustavo", fechaActual.toLocaleDateString());
let customer7 = new Customer("Gonzalo", fechaActual.toLocaleDateString());
let customer8 = new Customer("Lexi", fechaActual.toLocaleDateString());
let customer9 = new Customer("Kylie", fechaActual.toLocaleDateString());
let customer10 = new Customer("Dayana", fechaActual.toLocaleDateString());

customers.push(customer1, customer2, customer3, customer4, customer5, customer6, customer7, customer8, customer9, customer10);

let ul = "<ul>";

customers.forEach(c => {
    ul += ("<li>" + c.name + " " + c.fecha + "</li>\n");
});

ul += "</ul>";
console.log(ul);