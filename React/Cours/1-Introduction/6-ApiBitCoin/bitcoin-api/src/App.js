import './App.css';
import { useState, useEffect } from 'react'
import Chart from 'react-apexcharts'

function App() {
  const [loading, setLoading] = useState(true);
  const [priceData, setPriceData] = useState(null);
  const [currency, setCurrency] = useState(null);
  const [charData, setCharData] = useState(null);
  const [series, setSerie] = useState(null);

  useEffect(() => {
    async function fetchPrices() {
      const response = await fetch('https://api.coindesk.com/v1/bpi/currentprice.json');
      const data = await response.json();
      if (data !== null) {
        setCurrency(data.bpi.EUR.code);
        setPriceData(data.bpi);
        getCharData()
      }
    }
    fetchPrices();
  }, [])

  const getCharData = async () => {
    const response = await fetch('https://api.coindesk.com/v1/bpi/historical/close.json?start=2021-01-01&end=2021-10-26');
    const data = await response.json();
    const categories = Object.keys(data.bpi);
    const series = Object.values(data.bpi)
    setCharData({
      xaxis: {
        categories: categories
      }
    })
    setSerie([
      {
        name: "BitCoin Prices",
        data: series
      }
    ])
    setLoading(false);
  }


  return (
    <div className="container">
      <div className="nav">
        <span className='titre'>Coindesk API</span>
      </div>
      {loading ? (<div> Loading...</div>) : (
        <div>
          <div className="price-container">
            <div>
              <select onChange={(e) => setCurrency(e.target.value)} className='form-control'>
                <option value="EUR" selected>EUR (€)</option>
                <option value="USD">USD ($)</option>
                <option value="GBP">GBP (£)</option>
              </select>
            </div>
            <div className="price">
              <span>{currency} Price : <b> {Math.round(priceData[currency].rate_float * 100) / 100} {currency === "EUR" ? "€" : currency === "USD" ? "$" : "£"}</b></span>
            </div>
          </div>
          <div className="chart">
            <Chart
              options={charData}
              series={series}
              type='line'
              width='600'
              height='300'
            />
          </div>
          <div className="chart">
            <Chart
              options={charData}
              series={series}
              type='area'
              width='600'
              height='300'
            />
          </div>
          <div className="chart">
            <Chart
              options={charData}
              series={series}
              type='bar'
              width='600'
              height='300'
            />
          </div>
        </div>
      )}
    </div>
  );
}

export default App;
