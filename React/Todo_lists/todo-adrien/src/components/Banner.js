import '../styles/Banner.css'

function Banner(props) {
    return (
        <h1 className='title nav'>{props.msg}</h1>
    )
}

export default Banner