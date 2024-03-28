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