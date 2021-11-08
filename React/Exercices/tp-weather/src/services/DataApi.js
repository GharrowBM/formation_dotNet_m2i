import axios from "axios"

const baseUrl = "https://api.openweathermap.org/data/2.5/weather?appid=801d159ab9b9e7ee80167bfdd3873e76&units=metric&lang=fr"

export const getFromApi = (city) => {
    return axios.get(`${baseUrl}&q=${city}`)
}