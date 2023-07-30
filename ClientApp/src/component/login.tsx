import AuthSvc from "../services/authSvc";



export default function Login() {
    function Login(){
           AuthSvc.login('phuocnguyen', '123456').then(result => {
            debugger;
           });
    }
    return (
        <div className="container">
            <div className="login-form">
                <div className="form-logo">
                </div>
                <label>Tên Đăng Nhập
                    <input className="form-control"></input>
                </label>
                <label>Mật Khẩu
                    <input className="form-control" type="password"></input>
                </label>
                <div style={{marginTop: '10px'}}>
                    <button className="btn btn-primary" onClick={Login}>Đăng nhập</button>
                </div>
            </div>
        </div>
    );
}