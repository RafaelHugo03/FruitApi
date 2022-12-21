import { http } from "./config";

export default {
    getFruits: () => 
    {
        return http.get('/fruits/get-fruits')
    }
}