import axios  from 'axios';

const api = axios.create({
    baseURL:"https://localhost:7060/swagger/v1/swagger.json"
});

export default api;