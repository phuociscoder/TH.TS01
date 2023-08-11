import { useState } from "react";
import AuthSvc from "../services/authSvc";
import { ToastContainer, toast } from "react-toastify";
import { useNavigate, Route, redirect } from "react-router-dom";



export default function Login() {

    const [userName, setUserName] = useState("");
    const [password, setPassword] = useState("");
    const [isSuccess, setIsSuccess] = useState(true);
    const navigate = useNavigate();
    function Login() {
       
           AuthSvc.login(userName, password).then(result => {
            let data = result.data;
            if(!data.isSuccess)
            {
                setIsSuccess(false);
                return;
            }
            localStorage.setItem('User-app', JSON.stringify(data));
            setIsSuccess(true);
            navigate("/timesheet");
           });
    }
    return (

        <div className="container">
            <div className="card">
                <div className="form-logo">
                </div>
                
                <label>Tên Đăng Nhập

                    <input value={userName} onChange={(e) => { setUserName(e.target.value) }} className="form-control"></input>
                </label>

                <label>Mật Khẩu
                    <input value={password} onChange={(e) => { setPassword(e.target.value) }} className="form-control" type="password"></input>
                </label>

                <p style={{display: isSuccess ? 'none' : 'block'}} className="error-text">* Sai tên đăng nhập hoặc mật khẩu . </p>
                <div style={{ marginTop: '10px' }}>
                    <button className="cssbuttons-io" onClick={Login}>
                        <span> Đăng nhập</span>
                    </button>
                </div>
            </div>

        </div>
    );
}