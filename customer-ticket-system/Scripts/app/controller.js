app.controller("CustomerTicketController", function ($scope, CustomerTicketService) {

    $scope.questions = [
        {
            question: "3A Rupee Customer .S service care number 0: 7751810470/.7751810470",
            description: "Very much for your wishes and blessings to you support now help me post porbandar hi"
        },
        {
            question: "Customize antiforgery failure response",
            description: "I want to customize the response received by the client when CSRF token validation fails. I was looking at ASP.NET Core's source code and found the middleware I think is supposed to handle CSRF token validation. By looking at it I found that it sets an…"
        },
        {
            question: "Azure active Directory Authentication",
            description: "Hello, guys How can i disable Azure active Directory Authentication?"
        },
        {
            question: "Unable to copy payload from snowflake sql rest api to Azure blob ",
            description: "Hi , I am using web activity to get oauth token and passing subscription key and token to get method source dataset in a copy activity. postman is giving correct result but getting below error:-"
        },
        {
            question: "Extraction and Loading of OData to Postgresql issue with ADF pipeline with SOOM ",
            description: "our requirement to perform Extraction and Loading of OData to Postgresql using ADF pipeline is having issues related to System Out Of Memory exception randomly and sometimes with the max buffer issues. For the same pipeline run which worked and completed…"
        },
        {
            question: "Reduce the Azure vnet address space ",
            description: "Hello Team, I need to reduce the address space as below at the VNet for one of my project. this vnet also peered with other Vnet. also this vnet has express route and site to site vpn connected. by reducing i will save the ip address which i can use for…"
        },
    ]
    $scope.helloMessage = "Hello";
});