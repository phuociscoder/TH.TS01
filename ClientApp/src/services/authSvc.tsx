import  axios  from "axios";

// export default class AuthSvc {
 
//     constructor(){

//     }

//   public Login(userName: string, password: string){
//        axios.post('/api/user/login', { 
//               userName: userName,
//               lastName: password
//             });
//     }
// }

const AuthSvc = {
    login : function(userName: string, password: string){
       return axios.post('https://localhost:7179/api/user/login', { 
                          userName: userName,
                          password: password
                        });
    }
};

export default AuthSvc;