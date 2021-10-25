function Header() {
    return (
        <div>
            <div className="header">
                <img src="https://www.adira.org/wp-content/uploads/2019/05/9641_logo_m2iFormation_web-2.jpg" alt="LogoM2I" height="150px" />
                <h2>M2i Formation</h2>
            </div>
        </div>
    )
}

function Description() {
    return (
        <div className="header">
            <div className="description">Lorem ipsum dolor sit amet consectetur, adipisicing elit. Nostrum, vel.</div>
        </div>
    )
}

function Banner() {
    return (
        <div>
            <div className="banner">
                < Header />
            </div>
            <div className="description">
                <Description />
            </div>
        </div>
    )
}


ReactDOM.render(<Banner/>, document.getElementById('root'))