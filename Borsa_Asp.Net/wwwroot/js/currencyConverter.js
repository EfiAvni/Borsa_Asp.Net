document.getElementById('convertButton').addEventListener('click', function () {
    var amount = parseFloat(document.getElementById('amount').value);
    var fromCurrency = document.getElementById('fromCurrency').value;
    var toCurrency = document.getElementById('toCurrency').value;

    if (isNaN(amount) || amount <= 0) {
        alert('Lütfen geçerli bir tutar girin.');
        return;
    }

    var exchangeRates = {
        'USD': { 'TRY': 18.75, 'EUR': 0.93, 'GBP': 0.75, 'USD': 1 },
        'EUR': { 'TRY': 20.16, 'USD': 1.08, 'GBP': 0.81, 'EUR': 1 },
        'TRY': { 'USD': 0.053, 'EUR': 0.050, 'GBP': 0.040, 'TRY': 1 },
        'GBP': { 'TRY': 25.01, 'USD': 1.33, 'EUR': 1.23, 'GBP': 1 }
    };

    if (fromCurrency === toCurrency) {
        document.getElementById('convertedValue').textContent = amount + ' ' + fromCurrency;
    } else {
        var result = amount * exchangeRates[fromCurrency][toCurrency];
        document.getElementById('convertedValue').textContent = result.toFixed(2) + ' ' + toCurrency;
    }
});
