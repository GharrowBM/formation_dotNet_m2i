import { PureComponent } from "react"
import { connect } from "react-redux"
import { getWeater } from "../redux/actions";
import { Row, Col, Input, Button } from "antd"
class FormContainer extends PureComponent {
    constructor(props) {
        super(props);
        this.state = {}
    }
    render() {
        return (
            <div>
                <Row>
                    <Col span={9}>
                        <Input placeholder="Ville..." />
                    </Col>
                    <Col span={9}>
                        <Input placeholder="Pays..." />
                    </Col>
                    <Col span={6}>
                        <Button type="primary"  loading={this.props.loading}>
                            Get Weather
                        </Button>
                    </Col>
                </Row>
            </div>
        );
    }
}


const mapStateToProps = (state) => {
    return {
        loading: state.weather.isLoading
    }
}

const mapActionToProps = (dispatch) => {
    return {
        getWeather: (city) => dispatch(getWeater(city))
    }
}

export default connect(mapStateToProps, mapActionToProps)(FormContainer);