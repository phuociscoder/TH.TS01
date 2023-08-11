import { DayPicker } from "react-day-picker";

export default function Dashboard() {
    return (
        <div className="dashboard-container">
            <div className="col-sm-12 card-wraper">
                <div className="card-detail ">
                    <span className="card-text">Hi,</span>
                    <p className="card-value">Nguyễn Hữu Phước</p>
                </div>
                <div className="card-detail ">
                    <span className="card-text">Lương Cơ bản</span>
                    <p className="card-value">20.000</p>
                </div>
                <div className="card-detail ">
                    <span className="card-text">Tổng giờ làm</span>
                    <p className="card-value">192</p></div>
                <div className="card-detail ">
                <span className="card-text">Tổng Lương</span>
            <p className="card-value">2.750.000</p>
                </div>
                <div className="card-detail ">
                <span className="card-text">Tổng Phạt/Ứng</span>
            <p className="card-value">200.000</p>
                </div>
                <div className="card-detail ">
                <span className="card-text">Thực Nhận</span>
            <p className="card-value">2.500.000</p>
                </div>
            </div>
            <div className="col-sm-12 card-wraper">
            <div className="card-detail ">
                <span className="card-text">Từ Ngày</span>
                <input className="form-control" type="date" />
                </div>

                <div className="card-detail ">
                <span className="card-text">Đến Ngày</span>
                <input className="form-control" type="date" />
                </div>
                
            </div>
            <div className="col-sm-12 card-wraper">
                <div className="card-detail" style={{width: '100%'}}>
                <span className="card-text">Làm việc 11/08/2023</span>
                <div className="checkinout-wrapper">
                    <button className="btn btn-primary">Bắt đầu làm việc</button>
                    <span>Bắt đầu lúc: 11/08/2023 07:36:00</span>
                    <span>Kết thúc lúc: -</span>
                    <span>Trạng Thái: Đang làm việc</span>
                    <span>Đánh giá: Tốt</span>
                </div>
                </div>
            </div>
        </div>
    );
}