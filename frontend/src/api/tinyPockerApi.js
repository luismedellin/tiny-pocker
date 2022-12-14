import axios from 'axios';

const tinyPockerApi = axios.create({
    baseURL: import.meta.env.VITE_API_TINY_POCKER_URL
});

tinyPockerApi.interceptors.request.use( config => {

    config.headers = {
        ...config.headers,
    };

    return config;
})

export default tinyPockerApi;