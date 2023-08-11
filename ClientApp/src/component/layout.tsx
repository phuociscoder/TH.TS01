import { useEffect, useState } from "react";
import { Outlet, useNavigate } from "react-router-dom";

export default function Layout() {
    const [fullName, setFullName] = useState("");
    const navigate = useNavigate();
    useEffect(() => {
        const userData = localStorage.getItem('User-app');
        if (!userData) return navigate("/login");

        setFullName(JSON.parse(userData).fullName);
    })

    const Logout = () => {
        // localStorage.removeItem("User-app");
        navigate("/login");
    }

    return (
        <>
            <div className="nav-bar">
                <div className="main-logo col-md-1" />
                <div data-text="Awesome" className="col-md-3 title-wrap">
                    <p className="title" >TỨ HẢI BILIARD</p>
                    <span className="sub-title"> - Kết nối đam mê</span>
                </div>

                <div className="menu col-md-5">
                    <button data-text="Awesome" className="button">
                        <span className="actual-text">&nbsp;Nhân&nbsp;Viên&nbsp;</span>
                        <span className="hover-text" aria-hidden="true">&nbsp;Nhân&nbsp;Viên&nbsp;</span>
                    </button>
                    <button data-text="Awesome" className="button">
                        <span className="actual-text">&nbsp;Time&nbsp;Sheet&nbsp;</span>
                        <span className="hover-text" aria-hidden="true">&nbsp;Time&nbsp;Sheet&nbsp;</span>
                    </button>
                    <button data-text="Awesome" className="button">
                        <span className="actual-text">&nbsp;Kiểm&nbsp;Kê&nbsp;</span>
                        <span className="hover-text" aria-hidden="true">&nbsp;Kiểm&nbsp;Kê&nbsp;</span>
                    </button>
                    
                </div>
                <div className="action-nav">
                    <span className="sub-title">Xin chào ,{fullName}</span>
                    <button style={{marginLeft: '5px'}} className="btn btn-primary" onClick={Logout}>
                        Đăng xuất
                    </button>
                </div>
            </div>
            <Outlet />
        </>
    );
}