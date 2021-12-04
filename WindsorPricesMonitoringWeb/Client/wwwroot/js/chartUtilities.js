function createChart(num) {
    const labels = [
        'January',
        'February',
        'March',
        'April',
        'May',
        'June',
    ];
    const data = {
        labels: labels,
        datasets: [{
            label: 'My First dataset',
            backgroundColor: 'rgb(255, 99, 132)',
            borderColor: 'rgb(255, 99, 132)',
            data: [0, 10, 5, 2, 20, 35],
        }]
    };

    const myChart = new Chart(
        document.getElementById('myChart'),
        {
            type: 'line',
            data,
            options: {}
        }
    );
}