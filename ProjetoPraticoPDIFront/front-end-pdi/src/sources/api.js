import axios  from 'axios';

const api = axios.create({
    baseURL:"https://localhost:7060/ProjetoPraticoPDI"
});

export default api;