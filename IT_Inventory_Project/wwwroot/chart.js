//window.setup = (id, config) => {
//    var ctx = document.getElementById(id).getContext('2d');
//    new Chart(ctx, config);
//}

window.setup = (id, config) => {
    let canvas = document.getElementById(id);
    if (canvas) {
        let ctx = canvas.getContext('2d');
        new Chart(ctx, config);
    } else {
        console.error(`Element with id ${id} not found`);
    }
};

//function createBarChart(canvasId, chartData) {
//    const ctx = document.getElementById(canvasId).getContext('2d');
//    new Chart(ctx, JSON.parse(chartData));
//}

function createBarChart(canvasId, chartData) {
    const ctx = document.getElementById(canvasId)
    if (ctx) {
        let canvas = ctx.getContext('2d');
        new Chart(ctx, JSON.parse(chartData));
    }
    else {
        console.error(`Element with id ${id} not found`);
    }
}

window.createChart = () => {
    var data = {
        labels: ["Red", "Blue", "Yellow", "Green", "Purple", "Orange"],
        datasets: [{
            label: '# of Votes',
            data: [12, 19, 3, 5, 2, 3],
            backgroundColor: [
                'rgba(255, 99, 132, 0.2)',
                'rgba(54, 162, 235, 0.2)',
                'rgba(255, 206, 86, 0.2)',
                'rgba(75, 192, 192, 0.2)',
                'rgba(153, 102, 255, 0.2)',
                'rgba(255, 159, 64, 0.2)'
            ],
            borderColor: [
                'rgba(255, 99, 132, 1)',
                'rgba(54, 162, 235, 1)',
                'rgba(255, 206, 86, 1)',
                'rgba(75, 192, 192, 1)',
                'rgba(153, 102, 255, 1)',
                'rgba(255, 159, 64, 1)'
            ],
            borderWidth: 1
        }]
    };

    var options = {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }
    };

    var ctx = document.getElementById('myChart').getContext('2d');
    var myChart = new Chart(ctx, {
        type: 'bar',
        data: data,
        options: options
    });
};

window.createChartWithAPIData = (data) => {
    var labels = ["Red", "Blue", "Yellow", "Green", "Purple", "Orange"];
    var backgroundColors = [
        'rgba(255, 99, 132, 0.2)',
        'rgba(54, 162, 235, 0.2)',
        'rgba(255, 206, 86, 0.2)',
        'rgba(75, 192, 192, 0.2)',
        'rgba(153, 102, 255, 0.2)',
        'rgba(255, 159, 64, 0.2)'
    ];
    var borderColors = [
        'rgba(255, 99, 132, 1)',
        'rgba(54, 162, 235, 1)',
        'rgba(255, 206, 86, 1)',
        'rgba(75, 192, 192, 1)',
        'rgba(153, 102, 255, 1)',
        'rgba(255, 159, 64, 1)'
    ];

    var chartData = {
        labels: labels,
        datasets: [{
            label: '# of Votes',
            data: data,
            backgroundColor: backgroundColors,
            borderColor: borderColors,
            borderWidth: 1
        }]
    };

    var options = {
        scales: {
            yAxes: [{
                ticks: {
                    beginAtZero: true
                }
            }]
        }
    };

    var ctx = document.getElementById('myChart').getContext('2d');
    var myChart = new Chart(ctx, {
        type: 'bar',
        data: chartData,
        options: options
    });
};