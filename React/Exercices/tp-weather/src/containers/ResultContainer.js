import { PureComponent } from "react";
import { connect } from "react-redux";
import {Card, Col, Row} from "antd"
class ResultContainer extends PureComponent {
    constructor(props) {
        super(props);
        this.state = {  }
    }
    render() { 
        return (
            <Row justify="center">
                <Col>
                    {this.props.weather != undefined ? (
                        <Card>
                            {this.props.weather.main.temp}
                        </Card>
                    ) : null}                    
                </Col>
            </Row>
         );
    }
}
const mapStateToProps = (state) => {
    return {
        weather : state.weather.weather,
        error: state.weather.error
    }
}
export default connect(mapStateToProps, null)(ResultContainer);